using Shop.Database;
using Shop.Application.ViewModels;

namespace Shop.Application.Products;

/// <summary>
/// This class will handle showing all of the products to users.
/// </summary>
public class GetAllProducts
{
    private readonly AppDbContext _dbContext;

    public GetAllProducts(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Return all of the products
    /// </summary>
    /// <returns>IEnumerable<ProductViewModel></returns>
    public IEnumerable<ProductViewModel> Get()
    {
        return _dbContext.Products.ToList().Select(p => new ProductViewModel{
            Title = p.Title,
            Description = p.Description,
            Price = p.Price
        });
    }
}