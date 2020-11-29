using System.Linq;
using Airport.Data.AirlineCompany;

namespace Airport.Infra.AirlineCompany
{
    public class AirlineCompaniesDbInitializer : DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeAirlineCompanys(db);
        }
        private static void InitializeAirlineCompanys(AirportDbContext db)
        {
            if (db.AirlineCompanies.Count() != 0) return;
            var airports = new[] {
                new AirlineCompanyData {
                    Id = "SWE", Name = "Air Leap", Address = "AirLeap.com"
                },
                new AirlineCompanyData {
                    Id = "LAT", Name = "Air Baltic", Address = "AirBaltic.com"
                },
                new AirlineCompanyData{
                    Id = "DMK", Name = "Danish Air Transport", Address = "DanishAirTransport.com"
                }
            };
            AddSet(airports, db);
        }
    }
}
