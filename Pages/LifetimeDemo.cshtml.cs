using CityBreaks1.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks1.Pages
{
    public class LifetimeDemoModel : PageModel
    {
        private readonly LifetimeDemoService _lifetimeDemoService;
        private readonly LifetimeDemoService _secondService;
        public LifetimeDemoModel(LifetimeDemoService lifetimeDemoService,
            LifetimeDemoService secondService)
        {
            _lifetimeDemoService = lifetimeDemoService;
            _secondService = secondService;
        }

        public Guid Value { get; set; }
        public Guid SecondValue { get; set; }
        public void OnGet()
        {
            Value = _lifetimeDemoService.Value;
            SecondValue = _secondService.Value;
        }
    }
}
