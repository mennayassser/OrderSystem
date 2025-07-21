
namespace Market.Services
{
    public interface IConsumer
    {
        Task StartConsumingAsync(CancellationToken cancellationToken);
    }
}