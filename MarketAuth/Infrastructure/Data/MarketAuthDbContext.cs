using MarketAuth.Domain;
using Microsoft.EntityFrameworkCore;

namespace MarketAuth.Infrastructure.Data
{
    public class MarketAuthDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MarketAuthDbContext(DbContextOptions<MarketAuthDbContext> options)
            : base(options)
        {
            try
            {
                Database.Migrate();
                Console.WriteLine("[MarketAuth] Database migration completed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MarketAuth] Database migration error: {ex.Message}");
                throw;
            }
        }
    }
}
