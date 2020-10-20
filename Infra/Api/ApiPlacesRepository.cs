using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiPlacesRepository : IApiPlacesRepository
    {
        private PlaceData places = new PlaceData();

        private async Task<PlaceData> apiConnection(string name = "")
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
                return JsonConvert.DeserializeObject<PlaceData>(body);
            }
        }

        public PlaceProperties Get(string id)
        {
            return places.Places.FirstOrDefault(x => x.PlaceId == id);
        }

        public async Task<PlaceData> GetAll()
        {
            places.Places.Clear();
            var data = await apiConnection();
            data.Places.ForEach(x => places.Places.Add(x));
            return places;
        }
        public async Task<PlaceData> GetAll(string name)
        {
            places.Places.Clear();
            var data = await apiConnection(name);
            data.Places.ForEach(x => places.Places.Add(x));
            return places;
        }
    }
}
