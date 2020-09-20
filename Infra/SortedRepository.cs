using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Airport.Data.Common;
using Airport.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Airport.Infra
{
    public abstract class SortedRepository<TDomain, TData> : BaseRepository<TDomain, TData>, ISorting
        where TData : UniqueEntityData, new()
        where TDomain : Entity<TData>, new()
    {
        public string SortOrder { get; set; }
        public string DescendingString => "_desc";


        protected SortedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }


        public override IQueryable<TData> CreateSqlQuery() => AddSorting(base.CreateSqlQuery());

        public IQueryable<TData> AddSorting(IQueryable<TData> query)
        {
            var expression = CreateExpression();
            return expression is null ? query : AddOrderBy(query, expression);
        }

        public Expression<Func<TData, object>> CreateExpression()
        {
            var property = FindProperty();

            return property is null ? null : LambdaExpression(property);
        }

        internal Expression<Func<TData, object>> LambdaExpression(PropertyInfo p)
        {
            var param = Expression.Parameter(typeof(TData), "x");
            var property = Expression.Property(param, p);
            var body = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<TData, object>>(body, param);
        }

        public PropertyInfo FindProperty() => typeof(TData).GetProperty(GetName());

        public string GetName()
        {
            if (string.IsNullOrEmpty(SortOrder)) return string.Empty;
            var idx = SortOrder.IndexOf(DescendingString, StringComparison.Ordinal);

            return idx > 0 ? SortOrder.Remove(idx) : SortOrder;
        }

        public IQueryable<TData> AddOrderBy(IQueryable<TData> query, Expression<Func<TData, object>> e)
        {
            if (query is null) return null;
            if (e is null) return query;
            try { return IsDescending() ? query.OrderByDescending(e) : query.OrderBy(e); }
            catch { return query; }
        }

        public bool IsDescending() => !string.IsNullOrEmpty(SortOrder) && SortOrder.EndsWith(DescendingString);
    }
}
