using  Market.Models;
using Microsoft.EntityFrameworkCore;


namespace Market.Data
{
    public class MarketDbContext : DbContext
    {
        
            public DbSet<Product> Products { get; set; }
            public DbSet<Order> Orders { get; set; }

            public MarketDbContext(DbContextOptions<MarketDbContext> options)
                : base(options)
            {
            }

            
        
    }

}
