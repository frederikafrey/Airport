using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Data.Api.ApiCountry;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiCountriesRepository: IApiCountriesRepository

    {
    private ApiCountryData _apiCountryData = new ApiCountryData();

    private async Task<ApiCountryData> apiConnection()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://rapidapi.p.rapidapi.com/apiservices/reference/v1.0/countries/en-US"),
            Headers =
            {
                {"x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com"},
                {"x-rapidapi-key", "90d24628bdmsh2d12c093a69ca11p1bec1djsn596101fa32da"},
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiCountryData>(body);
        }
    }

    public ApiCountryProperties Get(string id)
    {
        return _apiCountryData.countries.FirstOrDefault(x => x.Code == id);
    }

    public async Task<ApiCountryData> GetAll()
    {
        _apiCountryData.countries.Clear();
        var data = await apiConnection();
        data.countries.ForEach(x => _apiCountryData.countries.Add(x));
        return _apiCountryData;
    }
    }
}
