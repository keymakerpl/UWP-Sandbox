namespace UWP.Core.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string Content { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
