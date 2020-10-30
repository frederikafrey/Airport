using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCurrency;

namespace Airport.Domain.Api
{
    public interface IApiCurrenciesRepository
    {
        ApiCurrencyProperties Get(string id);
        Task<IEnumerable<ApiCurrencyProperties>> GetAll();
    }
}
