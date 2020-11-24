using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using System.Linq;

namespace Airport.Infra
{
    public class AirportDbInitializer: DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            initializeAirports(db);
            initializeAirlineCompanys(db);
        }
        private static void initializeAirports(AirportDbContext db)
        {
            if (db.Airports.Count() != 0) return;
            var airports = new[] {
                new AirportData {
                    Id = "SWE", Country = "Sweden", Phone = "455 4555"
                },
                new AirportData {
                    Id = "LAT", Country = "Latvia", Phone = "644 6444"
                },
                new AirportData{
                    Id = "DMK", Country = "Denmark", Phone = "677 7666"
                }
            };
            addSet(airports, db);
        }
        private static void initializeAirlineCompanys(AirportDbContext db)
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
            addSet(airports, db);
        }
    }
}
