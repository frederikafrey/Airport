using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Airport.Data.StopOver;

namespace Airport.Infra.StopOver
{
    public class StopOversDbInitializer : DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            InitializeStopOvers(db);
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
