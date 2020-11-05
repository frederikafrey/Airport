using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCountry;
using Airport.Domain.Api;

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

//    private ApiCountryData _apiCountryData = new ApiCountryData();

//private async Task<ApiCountryData> ApiConnection()
//{
//    var client = new HttpClient();
//    var request = new HttpRequestMessage
//    {
//        Method = HttpMethod.Get,
//        RequestUri = new Uri("https://rapidapi.p.rapidapi.com/apiservices/reference/v1.0/countries/en-US"),
//        Headers =
//        {
//            {"x-rapidapi-Host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com"},
//            {"x-rapidapi-Key", "90d24628bdmsh2d12c093a69ca11p1bec1djsn596101fa32da"},
//        },
//    };
//    using (var response = await client.SendAsync(request))
//    {
//        response.EnsureSuccessStatusCode();
//        var body = await response.Content.ReadAsStringAsync();
//        return JsonConvert.DeserializeObject<ApiCountryData>(body);
//    }
//}





