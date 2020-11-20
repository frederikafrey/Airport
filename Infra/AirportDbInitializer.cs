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
        internal static AirportDbContext db;

        public static void Initialize(AirportDbContext c)
        {
            db = c;
            initialize(Airports.AirportList);
        }
        internal static void initialize(IEnumerable<AirportInfo> data)
        {
            foreach (var d in from d in data
                              let o = db.Airports.FirstOrDefaultAsync(m => m.Id == d.Id).GetAwaiter().GetResult()
                              where o is null
                              select d)
            {
                addItem(
                    new AirportData
                    {
                        Id = d.Id,
                        Country = d.Country,
                        Phone = d.Phone,
                    }, db);
            }
        }
        internal static void initialize(List<AirportInfo> units)
        {
            addTerms(units);
        }
        internal static void addTerms(List<AirportInfo> units)
        {
            foreach (var d in units)
                addTerms(d, db.Airports);
        }
        internal static void addTerms<T>(AirportInfo measure, DbSet<T> set) where T : AirportData, new()
        {
            foreach (var d in measure.Terms)
            {
                var o = set.FirstOrDefaultAsync(
                    m => m.Id == measure.Id && m.Country == d.Country).GetAwaiter().GetResult();

                if (!(o is null)) continue;
                addItem(
                    new T
                    {
                        Id = measure.Id,
                        Country = d.Country,
                        Phone = d.Phone
                    }, db);
            }
        }
        internal static T getItem<T>(IQueryable<T> set, string id) where T : UniqueEntityData
           => set.FirstOrDefaultAsync(m => m.Id == id).GetAwaiter().GetResult();
        static internal protected void addItem<T>(T item, DbContext db) where T : AirportData
        {
            db?.Add(item);
            db?.SaveChanges();
        }
    }
}
