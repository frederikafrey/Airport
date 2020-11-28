using Airport.Aids;
using Airport.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Airport.Infra
{
    public class DbInitializer
    {
        static internal protected void AddSet<T>(IEnumerable<T> set, DbContext db) where T : UniqueEntityData
        {
            try
            {
                db?.AddRange(set);
                db?.SaveChanges();
            }
            catch (Exception e)
            {
                Log.Exception(e);
                RollBack(db);
                AddItems(set, db);
            }
        }

        static internal protected void AddItems<T>(IEnumerable<T> set, DbContext db) where T : UniqueEntityData
        {
            foreach (var e in set)
                AddItem(e, db);
        }

        static internal protected void AddItem<T>(T item, DbContext db) where T : UniqueEntityData
        {
            try
            {
                db?.Add(item);
                db?.SaveChanges();
            }
            catch (Exception e)
            {
                Log.Exception(e);
                RollBack(db);
                try
                {
                    db?.Update(item);
                    db?.SaveChanges();
                }
                catch (Exception e1)
                {
                    Log.Exception(e1);
                    RollBack(db);
                }
            }
        }

        static internal protected void RollBack(DbContext db)
        {
            var changedEntries = db.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }
    }
}
