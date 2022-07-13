namespace Shop.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderReference { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }

        public ICollection<OrderProduct> OrderProduct { get; set; }
    }
}