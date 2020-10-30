using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCurrency;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiCurrenciesRepository: IApiCurrenciesRepository
    {
        private ApiCurrencyData _apiCurrencyData = new ApiCurrencyData();

        private async Task<ApiCurrencyData> ApiConnection()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/reference/v1.0/currencies"),
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
                return JsonConvert.DeserializeObject<ApiCurrencyData>(body);
            }
        }

        public ApiCurrencyProperties Get(string id)
        {
            return _apiCurrencyData.currencies.FirstOrDefault(x => x.Code == id);
        }

        public async Task<IEnumerable<ApiCurrencyProperties>> GetAll()
        {
            _apiCurrencyData.currencies.Clear();
            var data = await ApiConnection();
            data.currencies.ForEach(x => _apiCurrencyData.currencies.Add(x));
            return _apiCurrencyData.currencies;
        }
    }
}
