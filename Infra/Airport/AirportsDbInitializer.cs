using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using Airport.Data.StopOver;
using System.Linq;

namespace Airport.Infra
{
    public class AirportsDbInitializer: DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeAirports(db);
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
    }
}
