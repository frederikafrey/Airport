using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiCarrier;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiCarriersRepository:IApiCarriersRepository
    {
        private ApiCarrierData _apiCarrierData = new ApiCarrierData();

        private async Task<ApiCarrierData> ApiConnection()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01"),
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
                return JsonConvert.DeserializeObject<ApiCarrierData>(body);
            }
        }

        public ApiCarrierProperties Get(string id)
        {
            return _apiCarrierData.carriers.FirstOrDefault(x => x.Name == id);
        }

        public async Task<IEnumerable<ApiCarrierProperties>> GetAll()
        {
            _apiCarrierData.carriers.Clear();
            var data = await ApiConnection();
            data.carriers.ForEach(x => _apiCarrierData.carriers.Add(x));
            return _apiCarrierData.carriers;
        }
    }
}
