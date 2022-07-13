using Shop.Database;
using Shop.Domain.Models;
using Shop.Application.ViewModels;
using Shop.Application.AdminProducts.ViewModel;

namespace Shop.Application.AdminProducts;

/// <summary>
/// This class will handle the creation of a new product.
/// </summary>
public class CreateProduct
{
    private readonly AppDbContext _dbContext;

    public CreateProduct(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="vm"></param>
    /// <returns>AdminProductViewModel</returns>
    public async Task<AdminProductViewModel> Create(ProductViewModel vm)
    {
        Product newProduct = new ();
        newProduct.Title = vm.Title;
        newProduct.Description = vm.Description;
        newProduct.Price = vm.Price;

        _dbContext.Products.Add(newProduct);
        await _dbContext.SaveChangesAsync();
        return new AdminProductViewModel{
            Id = newProduct.Id,
            Title = newProduct.Title,
            Description = newProduct.Description,
            Price = newProduct.Price,
        };
    }
}