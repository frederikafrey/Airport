using Airport.Data.Airport;
using Airport.Data.Common;
using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Infra
{
    public class AirportDbInitializer: DbInitializer
    {
        public static void Initialize(AirportDbContext db)
        {
            initializeAirports(db);
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
    }
}
