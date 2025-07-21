using MarketService.Domain;

namespace MarketService.Application
{
    public interface IProducer
    {
        Task ProduceOrderMessage(Order order);
    }
} 