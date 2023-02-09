﻿using CityBreaks.Data;
using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Services;
public class CityService : ICityService
{
    private readonly CityBreaksContext _context;
    public CityService(CityBreaksContext context) => _context = context;
    public async Task<List<City>> GetAllAsync()
    {
        var cities = _context.Cities
            .Include(c => c.Country)
            .Include(c => c.Properties);
        return await cities.ToListAsync();
    }

    public async Task<City> GetByNameAsync(string name)
    {
        name = name.Replace("-", " ");
        return await _context.Cities
            .Include(c => c.Country)
            .Include(c => c.Properties.Where(p =>
     p.AvailableFrom < DateTime.Now))
            .SingleOrDefaultAsync(c =>
     EF.Functions.Collate(c.Name, "NOCASE") == name);
    }
}
