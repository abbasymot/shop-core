using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;
using Shop.Application.ViewModels;

namespace Shop.UI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly AppDbContext _dbContext;

    public IndexModel(ILogger<IndexModel> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

     [BindProperty]
    public ProductViewModel Product { get; set; }
    public IEnumerable<ProductViewModel> Products { get; set; }

    public void OnGet()
    {
        Products = new GetAllProducts(_dbContext).Get();
    }

}
