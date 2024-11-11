using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class SeriesModel : PageModel
{
    private readonly ILogger<SeriesModel> _logger;

    public SeriesModel(ILogger<SeriesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

