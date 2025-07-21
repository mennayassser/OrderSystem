namespace Market.Models
{
    public class Order
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = null;
        public int Price { get; set; }
       
        public string Direction { get; set; } = null;
        public int Quantity { get; set; }
        public string Products { get; set; } = null;


    }
}
