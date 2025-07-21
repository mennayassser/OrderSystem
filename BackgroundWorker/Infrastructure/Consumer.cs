using BackgroundWorker.Application;
using MarketService.Domain;
using Microsoft.AspNetCore.SignalR;
using BackgroundWorker.Infrastructure.Hubs;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace BackgroundWorker.Infrastructure
{
    public class Consumer : IConsumer
    {
        private readonly ILogger<Consumer> _logger;
        private readonly IHubContext<OrderHub> _hubContext;

        public Consumer(ILogger<Consumer> logger, IHubContext<OrderHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task StartConsumingAsync(CancellationToken cancellationToken)
        {
            var factory = new ConnectionFactory
            {
                HostName = "host.docker.internal",
                UserName = "menna",
                Password = "mennaMQ"
            };
            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync("orders", durable: true, exclusive: false, autoDelete: false, cancellationToken: cancellationToken);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (model, ea) =>
            {
                var json = Encoding.UTF8.GetString(ea.Body.ToArray());
                var order = JsonSerializer.Deserialize<Order>(json);

                if (order != null)
                {
                    await _hubContext.Clients.All.SendAsync("ReceiveOrder", order);
                    _logger.LogInformation("📥 Received message from RabbitMQ: {Message}", order);

                    channel.BasicAckAsync(ea.DeliveryTag, multiple: false);
                }
            };

            await channel.BasicConsumeAsync("orders", autoAck: false, consumer: consumer, cancellationToken: cancellationToken);
        }
    }
}
