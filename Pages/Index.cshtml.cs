using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string[] Cities { get; set; }
        public void OnGet()
        {
            Cities = new[] { "London", "Berlin", "Paris", "Rome" };
        }
    }
}