using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CityBreaks.Data;
using CityBreaks.Models;

namespace CityBreaks.Pages.PropertyManager
{
    public class IndexModel : PageModel
    {
        private readonly CityBreaks.Data.CityBreaksContext _context;

        public IndexModel(CityBreaks.Data.CityBreaksContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Properties != null)
            {
                Property = await _context.Properties
                .Include(m => m.City).ToListAsync();
            }
        }
    }
}
