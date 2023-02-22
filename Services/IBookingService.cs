using CityBreaks1.Models;

namespace CityBreaks1.Services
{
    public interface IBookingService
    {
        decimal Calculate(Booking booking);
    }
}
