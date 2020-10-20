using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiCountriesRepository: IApiCountriesRepository

    {
    private CountryData countryData = new CountryData();

    private async Task<CountryData> apiConnection()
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
            return JsonConvert.DeserializeObject<CountryData>(body);
        }
    }

    public CountryProperties Get(string id)
    {
        return countryData.Countries.FirstOrDefault(x => x.Code == id);
    }

    public async Task<CountryData> GetAll()
    {
        countryData.Countries.Clear();
        var data = await apiConnection();
        data.Countries.ForEach(x => countryData.Countries.Add(x));
        return countryData;
    }
    }
}
