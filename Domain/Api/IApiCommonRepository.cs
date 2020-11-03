using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiCarrier;

namespace Airport.Domain.Api
{
    public interface IApiCommonRepository<TData, TProperties>
    {
        TProperties Get(string id);
        Task<IEnumerable<TProperties>> GetAll();
    }
}
