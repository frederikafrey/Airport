using System.Linq;
using Airport.Data.Airport;

namespace Airport.Infra.Airport
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
                    Id = "EST", Country = "Estonia", Phone = "555 8555"
                },
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
