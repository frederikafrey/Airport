using System.Linq;
using Airport.Data.Luggage;
using Airport.Infra.Airport;

namespace Airport.Infra.Luggage
{
    public class WeightsDbInitializer : AirportsDbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeWeights(db);
        }
        private static void InitializeWeights(AirportDbContext db)
        {
            if (db.Luggages.Count() != 0) return;
            var weights = new[] {
                new LuggageData() {
                    Weight = "Max 5 kg"
                },
                new LuggageData() {
                    Weight = "Max 10 kg"
                },
                new LuggageData() {
                    Weight = "Max 25 kg"
                }
            };
            AddSet(weights, db);
        }
    }
}
