namespace MarketAuth.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = null;
        public string PasswordHash { get; set; } = null;

        // create email attribute if it will be used
    }
}
