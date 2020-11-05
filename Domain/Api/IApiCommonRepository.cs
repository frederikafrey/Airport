using System.Collections.Generic;
using System.Threading.Tasks;

namespace Airport.Domain.Api
{
    public interface IApiCommonRepository<TData, TProperties>
    {
        TProperties Get(string id);
        Task<IEnumerable<TProperties>> GetAll();
    }
}
