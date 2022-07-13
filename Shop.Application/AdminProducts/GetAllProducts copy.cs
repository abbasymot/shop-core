using Shop.Database;
using Shop.Application.AdminProducts.ViewModel;

namespace Shop.Application.AdminProducts;

/// <summary>
/// This class will handle showing all of the products to admin.
/// </summary>
public class GetAllProducts
{
    private readonly AppDbContext _dbContext;

    public GetAllProducts(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    /// <summary>
    /// Return all of the products as IEnumerable.
    /// </summary>
    /// <returns>IEnumerable<AdminProductViewModel></returns>
    public IEnumerable<AdminProductViewModel> Get()
    {
        return _dbContext.Products.ToList().Select(p => new AdminProductViewModel{
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            Price = p.Price
        });
    }
}