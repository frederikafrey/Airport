﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Common;
using Airport.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Airport.Infra
{
    public abstract class BaseRepository<TDomain, TData> : ICrudMethods<TDomain>
        where TData : UniqueEntityData, new()
        where TDomain : Entity<TData>, new()
    {
        protected internal DbContext db;
        public DbSet<TData> DbSet;

        protected BaseRepository(DbContext c, DbSet<TData> s)
        {
            db = c;
            DbSet = s;
        }

        public virtual async Task<List<TDomain>> Get()
        {
            var query = CreateSqlQuery();
            var set = await RunSqlQueryAsync(query);

            return ToDomainObjectsList(set);
        }

        public virtual IQueryable<TData> CreateSqlQuery() => from s in DbSet select s;

        internal async Task<List<TData>> RunSqlQueryAsync(IQueryable<TData> query) =>
            await query.AsNoTracking().ToListAsync();

        internal List<TDomain> ToDomainObjectsList(List<TData> set) => set.Select(ToDomainObject).ToList();

        protected internal abstract TDomain ToDomainObject(TData timeData);

        public async Task<TDomain> Get(string id)
        {
            if (id is null) return new TDomain();
            var data = await GetData(id);
            return ToDomainObject(data);
        }

        protected abstract Task<TData> GetData(string id);

        public async Task Delete(string id)
        {
            if (id is null) return;
            var data = await GetData(id);

            if (data is null) return;
            DbSet.Remove(data);
            await db.SaveChangesAsync();
        }

        public async Task Add(TDomain obj)
        {
            if (obj?.Data is null) return;
            DbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Update(TDomain obj)
        {
            if (obj is null) return;

            var data = await GetData(GetId(obj));
            if (data is null) return;

            DbSet.Remove(data);
            DbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        protected abstract string GetId(TDomain entity);
    }
}
