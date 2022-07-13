using System.ComponentModel;

namespace Shop.Domain.Models;

public class Product 
{
    public int Id { get; set; }
    
    [DisplayName("عنوان محصول")]
    public string Title { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }


    public ICollection<Stock> Stock { get; set; }
    public ICollection<OrderProduct> OrderProduct { get; set; }
}