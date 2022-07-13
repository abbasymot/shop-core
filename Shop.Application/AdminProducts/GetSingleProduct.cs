using Shop.Database;
using Shop.Application.AdminProducts.ViewModel;

namespace Shop.Application.AdminProducts;

/// <summary>
/// This class will handle getiing details of an existing product.
/// </summary>
public class GetSingleProduct
{
    private readonly AppDbContext _dbContext;

    public GetSingleProduct(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Find an existing product with id and return it.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>AdminProductViewModel</returns>
    public AdminProductViewModel Get(int id)
    {
        return _dbContext.Products.Where(x => x.Id == id).Select(x => new AdminProductViewModel
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            Price = x.Price,
        })
        .FirstOrDefault();
    }
}