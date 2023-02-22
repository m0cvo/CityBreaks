namespace CityBreaks1.Services
{
    public class UsPriceService : IPriceService
    {
        public string GetLocation() => "us";
        public double CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}
