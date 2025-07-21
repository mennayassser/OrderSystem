using System.Threading;

namespace BackgroundWorker.Application
{
    public interface IConsumer
    {
        Task StartConsumingAsync(CancellationToken cancellationToken);
    }
}