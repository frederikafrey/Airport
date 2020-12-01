using System.Linq;
using Airport.Data.Luggage;
using Airport.Infra.Airport;

namespace Airport.Infra.Luggage
{
    public class LuggagesDbInitializer : AirportsDbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeLuggages(db);
        }
        private static void InitializeLuggages(AirportDbContext db)
        {
            if (db.Luggages.Count() != 0) return;
            var luggages = new[] {
                new LuggageData {
                    Dimensions = "S: 40 x 30 x 20", Weight = "MAX 10 kg"
                },
                new LuggageData {
                    Dimensions = "M: 150 x 120 x 170", Weight = "MAX 32 kg"
                },
                new LuggageData {
                    Dimensions = "L: 100 x 50 x 80", Weight = "MAX 20 kg"
                }
            };
            AddSet(luggages, db);
        }
    }
}
