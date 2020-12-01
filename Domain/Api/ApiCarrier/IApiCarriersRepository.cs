using System.Collections.Generic;
using System.Threading.Tasks;

namespace Airport.Domain.Api.ApiCarrier
{
    public interface IApiCarriersRepository
    {
        ApiCarrierProperties Get(int id);
        Task<IEnumerable<ApiCarrierProperties>> GetAll();
    }
}
