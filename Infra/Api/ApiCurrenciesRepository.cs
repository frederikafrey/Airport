using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Api.ApiCommon;
using Airport.Domain.Api.ApiCurrency;

namespace Airport.Infra.Api
{
    public class ApiCurrenciesRepository : ApiCommonRepository<ApiCurrencyData>, IApiCommonRepository<ApiCurrencyData, ApiCurrencyProperties>
    {
        public ApiCurrenciesRepository()
        {
            var ee = jsonRepoData as ApiCurrencyData;
        }
        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/reference/v1.0/currencies";

        public ApiCurrencyProperties Get(string id)
        {
            var ee = jsonRepoData as ApiCurrencyData;
            return ee.currencies.FirstOrDefault(x => x.Code == id);
        }

        public async Task<IEnumerable<ApiCurrencyProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiCurrencyData;
            ee.currencies.Clear();
            var data = await CreateApiConnection();
            data.currencies.ForEach(x => ee.currencies.Add(x));
            return ee.currencies;
        }
    }
}