using Shop.Database;

namespace Shop.Application.AdminProducts;

/// <summary>
/// This class will handle deleting an existing product.
/// </summary>
public class DeleteProduct
{
    private readonly AppDbContext _dbContext;

    public DeleteProduct(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Find and delete a product with id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> Delete(int id)
    {
        var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
        _dbContext.Products.Remove(product);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}