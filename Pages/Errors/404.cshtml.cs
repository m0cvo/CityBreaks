using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages.Errors
{
    public class _404Model : PageModel
    {
        public string RequestUrl { get; set; }

        public void OnGet()
        {
            var feature =
     HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            RequestUrl = feature?.OriginalPath;
        }
    }
}
