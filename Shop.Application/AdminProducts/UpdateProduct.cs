using Shop.Database;
using Shop.Application.ViewModels;

namespace Shop.Application.AdminProducts;

/// <summary>
/// This class will handle updating of an existing product.
/// </summary>
public class UpdateProduct
{
    private readonly AppDbContext _dbContext;

    public UpdateProduct(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Get an PdoductViewModel and update the product.
    /// </summary>
    /// <param name="vm"></param>
    /// <returns></returns>
    public async Task<bool> Update(ProductViewModel vm)
    {
        await _dbContext.SaveChangesAsync();
        return true;
    }
}