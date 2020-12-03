using System.Linq;
using Airport.Data.Luggage;
using Airport.Infra.Airport;

namespace Airport.Infra.Luggage
{

    public class DimensionsDbInitializer : AirportsDbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeDimensions(db);
        }
        private static void InitializeDimensions(AirportDbContext db)
        {
            if (db.Luggages.Count() != 0) return;
            var dimensions = new[] {
                new LuggageData() {
                    Dimensions = "S: 40 x 30 x 20"
                },
                new LuggageData() {
                    Dimensions = "M: 100 x 50 x 80"
                },
                new LuggageData() {
                    Dimensions = "L: 150 x 120 x 170"
                }
            };
            AddSet(dimensions, db);
        }
    }
}
