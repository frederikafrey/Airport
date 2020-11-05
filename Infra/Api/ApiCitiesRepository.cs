using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCity;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiCitiesRepository : IApiCitiesRepository
    {
        private ApiCityData _apiCityData = new ApiCityData();

        private async Task<ApiCityData> ApiConnection(string name = "")
        {
            if (name == string.Empty) return new ApiCityData();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri =
                    new Uri(
                        "https://rapidapi.p.rapidapi.com/apiservices/autosuggest/v1.0/UK/GBP/en-GB/?query=" + name),
                Headers =
                {
                    {"x-rapidapi-Host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com"},
                    {"x-rapidapi-Key", "97661b7ec3mshd2fbff1d04efa8ap1b7b5cjsnc539884fce8a"},
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiCityData>(body);
            }
        }

        public ApiCityProperties Get(string id)
        {
            return _apiCityData.Places.FirstOrDefault(x => x.CityId == id);
        }

        public async Task<IEnumerable<ApiCityProperties>> GetAll(string name)
        {
            _apiCityData.Places.Clear();
            var data = await ApiConnection(name);
            data.Places.ForEach(x => _apiCityData.Places.Add(x));
            return _apiCityData.Places;
        }
        //public async Task<IEnumerable<ApiCityProperties>> GetAll()
        //{
        //    _apiCityData.Places.Clear();
        //    var data = await ApiConnection();
        //    data.Places.ForEach(x => _apiCityData.Places.Add(x));
        //    return _apiCityData.Places;
        //}

    }
}
