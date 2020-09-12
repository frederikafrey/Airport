namespace Airport.Domain.Common
{
    public interface IRepository<T> : ICrudMethods<T>, ISorting, IFiltering, IPaging { }
}
