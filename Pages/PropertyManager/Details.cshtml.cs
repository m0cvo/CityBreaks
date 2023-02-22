using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CityBreaks1.Data;
using CityBreaks1.Models;

namespace CityBreaks1.Pages.PropertyManager
{
    public class DetailsModel : PageModel
    {
        private readonly CityBreaks1.Data.CityBreaksContext _context;

        public DetailsModel(CityBreaks1.Data.CityBreaksContext context)
        {
            _context = context;
        }

      public Property Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Properties == null)
            {
                return NotFound();
            }

            var property = await _context.Properties.FirstOrDefaultAsync(m => m.Id == id);
            if (property == null)
            {
                return NotFound();
            }
            else 
            {
                Property = property;
            }
            return Page();
        }
    }
}
