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
        {//TODO luggage dimensions ja weight index lehelt ära
            if (db.Luggages.Count() != 0) return;
            var dimensions = new[] {
                new LuggageData() {
                    Id = "1",
                    PassengerId = "2",
                    Name = "Mari",
                    Dimensions = "S: 40 x 30 x 20",
                    Weight= "Max 5 kg"

                },
                new LuggageData() {
                    Id="2", 
                    PassengerId = "3",
                    Name = "Jaan",
                    Dimensions = "M: 100 x 50 x 80",
                    Weight = "Max 10 kg"
                },
                new LuggageData() {
                    Id="3",
                    PassengerId = "4",
                    Name = "Jaak",
                    Dimensions = "L: 150 x 120 x 170",
                    Weight = "Max 25 kg"
                }
            };
            AddSet(dimensions, db);
        }
    }
}
