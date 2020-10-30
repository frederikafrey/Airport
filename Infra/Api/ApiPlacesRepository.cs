using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api.ApiPlace;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiPlacesRepository : IApiPlacesRepository
    {
        private ApiPlaceData _apiPlaces = new ApiPlaceData();

        private async Task<ApiPlaceData> ApiConnection(string name = "")
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri =
                    new Uri(
                        "https://rapidapi.p.rapidapi.com/apiservices/autosuggest/v1.0/UK/GBP/en-GB/?query=" + name),
                Headers =
                {
                    {"x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com"},
                    {"x-rapidapi-key", "97661b7ec3mshd2fbff1d04efa8ap1b7b5cjsnc539884fce8a"},
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiPlaceData>(body);
            }
        }

        public ApiPlaceProperties Get(string id)
        {
            return _apiPlaces.places.FirstOrDefault(x => x.PlaceId == id);
        }

        public async Task<ApiPlaceData> GetAll()
        {
            _apiPlaces.places.Clear();
            var data = await ApiConnection();
            data.places.ForEach(x => _apiPlaces.places.Add(x));
            return _apiPlaces;
        }
        public async Task<ApiPlaceData> GetAll(string name)
        {
            _apiPlaces.places.Clear();
            var data = await ApiConnection(name);
            data.places.ForEach(x => _apiPlaces.places.Add(x));
            return _apiPlaces;
        }
    }
}
