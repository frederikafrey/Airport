using System;
using System.Linq;
using Airport.Data.Common;
using Airport.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Airport.Infra
{
    public abstract class PaginatedRepository<TDomain, TData> : FilteredRepository<TDomain, TData>, IPaging
        where TData : UniqueEntityData, new()
        where TDomain : Entity<TData>, new()
    {
        public int PageIndex { get; set; }
        public int TotalPages => GetTotalPages(PageSize);
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public int PageSize { get; set; } = 5;

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }


        public int GetTotalPages(int pageSize) => CountTotalPages(GetItemsCount(), pageSize);

        public int CountTotalPages(int count, in int pageSize) => (int)Math.Ceiling(count / (double)pageSize);

        public int GetItemsCount() => base.CreateSqlQuery().CountAsync().Result;

        public override IQueryable<TData> CreateSqlQuery() => AddSkipAndTake(base.CreateSqlQuery());

        public IQueryable<TData> AddSkipAndTake(IQueryable<TData> query)
        {
            if (PageIndex < 1) return query;
            return query
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize);
        }
    }
}
