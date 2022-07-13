using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Database;

namespace Shop.UI.Pages.Admin;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, AppDbContext dbContext)
    {
        _logger = logger;
    }


    public void OnGet()
    {
    }

}
