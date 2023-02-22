using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CityBreaks1.Data;
using CityBreaks1.Models;
using CityBreaks1.Services;

namespace CityBreaks1.Pages.PropertyManager
{
    public class IndexModel : PageModel
    {
        private readonly IPropertyService _propertyService;

        public IndexModel(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IList<Property> Property { get; set; }

        public async Task OnGetAsync()
        {
            Property = await _propertyService.GetAllAsync();
        }
    }
}
