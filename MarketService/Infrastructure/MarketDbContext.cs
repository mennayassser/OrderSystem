using MarketService.Domain;
using Microsoft.EntityFrameworkCore;

namespace MarketService.Infrastructure
{
    public class MarketDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public MarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
