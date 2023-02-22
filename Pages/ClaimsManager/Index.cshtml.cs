using CityBreaks1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks1.Pages.ClaimsManager
{
    public class IndexModel : PageModel
    {
        public UserManager<CityBreaksUser> UserManager { get; set; }
        public IndexModel(UserManager<CityBreaksUser> userManager)
        {
            UserManager = userManager;
        }
        public List<CityBreaksUser> Users { get; set; }
        public async Task OnGetAsync()
        {
            Users = await UserManager.Users.ToListAsync();
        }
    }
}