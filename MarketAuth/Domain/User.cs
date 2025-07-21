using System.ComponentModel.DataAnnotations;

namespace MarketAuth.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = null;
        public string PasswordHash { get; set; } = null;
        // create email attribute if it will be used
    }
}
