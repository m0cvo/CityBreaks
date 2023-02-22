using CityBreaks1.Models;

namespace CityBreaks1.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
        public Task<City> GetByNameAsync(string name) => throw new NotImplementedException();
    }
}