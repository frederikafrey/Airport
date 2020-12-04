using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Domain.Api.ApiCarrier;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiCarriersRepository: IApiCarriersRepository
    {
        private ApiCarrierData _apiCarrierData = new ApiCarrierData();
        protected ApiCarrierData jsonRepoData = new ApiCarrierData();
        protected string Host => "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        protected string Key => "2616562damsh2050e58368419afp15567bjsn92c0b7a0fcad";
        protected string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsequotes/v1.0/US/USD/en-US/SFO-sky/JFK-sky/2019-09-01?inboundpartialdate=2019-12-01";

        protected async Task<ApiCarrierData> CreateApiConnection()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(Url),
                Headers =
                {
                    {"x-rapidapi-Host", Host},
                    {"x-rapidapi-Key", Key},
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiCarrierData>(body);
            }
        }

        public ApiCarrierProperties Get(int id) => _apiCarrierData.carriers.FirstOrDefault(x => x.CarrierId == id);

        public async Task<IEnumerable<ApiCarrierProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiCarrierData;
            ee.carriers.Clear();
            var data = await CreateApiConnection();
            data.carriers.ForEach(x => ee.carriers.Add(x));
            return ee.carriers;
        }

    }
}

