using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminProducts;
using Shop.Application.ViewModels;
using Shop.Database;

namespace Shop.UI.Controllers;

[Route("[controller]")]

/// <summary>
/// This class will handle the Admin panel functionality
/// </summary>
public class AdminController: Controller 
{
    private readonly AppDbContext _dbContext;
    public AdminController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Return all of the products.
    /// </summary>
    /// <returns></returns>
    [HttpGet("products")]
    public IActionResult Products() {
        return Ok(new GetAllProducts(_dbContext).Get());
    }

    /// <summary>
    /// This method will get an id and find the related product and show the details.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("Products/{id}")]
    public IActionResult GetProduct(int id) => Ok(new GetSingleProduct(_dbContext).Get(id));

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="vm"></param>
    /// <returns></returns>
    [HttpPost("Products")]
    public async Task<IActionResult> CreateProduct([FromBody] ProductViewModel vm) => Ok(await new CreateProduct(_dbContext).Create(vm));

    // [HttpDelete("Products/{id}")]
    // public async Task<IActionResult> DeleteProduct(int id) => Ok(await new DeleteProduct(_dbContext).Delete(id));

    // [HttpPut("Products")]
    // public async Task<IActionResult> UpdateProduct([FromBody] ProductViewModel vm) {
    //     return Ok(await new UpdateProduct(_dbContext).Update(vm));

    // }
}