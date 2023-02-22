using Microsoft.AspNetCore.Identity;

namespace CityBreaks1.Models
{
    public class CityBreaksUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
