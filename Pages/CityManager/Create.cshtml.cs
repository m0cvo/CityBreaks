using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; }
    }
}