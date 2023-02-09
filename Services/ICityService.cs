using CityBreaks.Models;

namespace CityBreaks.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
        public Task<City> GetByNameAsync(string name) => throw new NotImplementedException();
    }
}