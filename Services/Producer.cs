using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace Market.Services
{
    public interface IProducer
    {
        Task ProduceOrderMessage(Models.Order order);
    }
    public class Producer : IProducer
    {
        public async Task ProduceOrderMessage(Models.Order order)
        {
            var factory = new ConnectionFactory
            {
                HostName = "host.docker.internal",
                UserName = "menna",
                Password = "mennaMQ"
            };
            await using var connection = await factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync("orders", durable: true, exclusive: false, autoDelete: false);

            var json = JsonSerializer.Serialize(order);
            var body = Encoding.UTF8.GetBytes(json);

            Console.WriteLine($"✅ Message sent to 'orders' queue: {json}");

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "orders", body: body);

        }

    }

}