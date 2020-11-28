using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using Airport.Data.StopOver;
using System.Linq;

namespace Airport.Infra
{
    public class AirportDbInitializer: DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeAirports(db);
            InitializeAirlineCompanys(db);
            InitializeStopOvers(db);
        }
        private static void InitializeAirports(AirportDbContext db)
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
            AddSet(airports, db);
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
        private static void InitializeStopOvers(AirportDbContext db)
        {
            if (db.StopOvers.Count() != 0) return;
            var airports = new[] {
                new StopOverData {
                    Id = "NL", Country = "Netherlands", City = "Amsterdam"
                },
                new StopOverData {
                    Id = "SP", Country = "Spain", City = "Madrid"
                },
                new StopOverData{
                    Id = "ENG", Country = "England", City = "London"
                },
                 new StopOverData{
                    Id = "AM", Country = "America", City = "Los Angeles"
                }
            };
            AddSet(airports, db);
        }
    }
}
