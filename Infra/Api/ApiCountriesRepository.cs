using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCountry;
using Airport.Domain.Api;
using Airport.Domain.Api.ApiCountry;

namespace Airport.Infra.Api
{
    public class ApiCountriesRepository : ApiCommonRepository<ApiCountryData>, IApiCountriesRepository
    {
        public ApiCountriesRepository()
        {
            var ee = jsonRepoData as ApiCountryData;
        }

        protected override string Url => "https://rapidapi.p.rapidapi.com/apiservices/reference/v1.0/countries/en-US";

        public ApiCountryProperties Get(string id)
        {
            var ee = jsonRepoData as ApiCountryData;
            return ee.countries.FirstOrDefault(x => x.Code == id);
        }

        public async Task<IEnumerable<ApiCountryProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiCountryData;
            ee.countries.Clear();
            var data = await CreateApiConnection();
            data.countries.ForEach(x => ee.countries.Add(x));
            return ee.countries;
        }
    }
}





