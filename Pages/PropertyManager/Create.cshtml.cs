using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CityBreaks.Pages.PropertyManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        [Display(Name = "Maximum Number of Guests")]
        public int MaxNumberOfGuests { get; set; }
        [BindProperty]
        [Display(Name = "Day Rate")]
        public decimal DayRate { get; set; }
        [BindProperty]
        [Display(Name = "Smoking Permitted")]
        public bool SmokingPermitted { get; set; }
        [BindProperty]
        [Display(Name = "Available From")]
        public DateTime AvailableFrom { get; set; }
        [BindProperty]
        [Display(Name = "City")]
        public int SelectedCity { get; set; }
        public SelectList Cities { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            Cities = GetCityOptions();
        }

        public void OnPost()
        {
            Cities = GetCityOptions();
            if (ModelState.IsValid)
            {
                var city = GetCityOptions().First(o => o.Value ==
         SelectedCity.ToString());
                Message = $"You selected {city.Text} with value of {SelectedCity}";
            }
        }

        private SelectList GetCityOptions()
        {
            var cities = new List<City>
    {
        new City{ Id = 1, Name = "London", Country = new Country{
 CountryName = "United Kingdom"} },
        new City{ Id = 2, Name = "York" , Country = new Country{
 CountryName = "United Kingdom"} },
        new City{ Id = 3, Name = "Venice", Country = new Country{
 CountryName = "Italy"} },
        new City{ Id = 4, Name = "Rome", Country = new Country{
 CountryName = "Italy" } },
        new City{ Id = 5, Name = "Madrid" , Country = new Country{
 CountryName = "Spain" } },
        new City{ Id = 5, Name = "Barcelona" , Country = new Country{
 CountryName = "Spain" } },
        new City{ Id = 5, Name = "Cadiz" , Country = new Country{
 CountryName = "Spain" } }
    };
            return new SelectList(cities, nameof(City.Id), nameof(City.Name),
         null, "Country.CountryName");
        }
    }
}
