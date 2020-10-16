using System;
using System.Net.Http;
using Airport.Data.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public class ApiPlacesRepository
    {
        public static async void ApiPlaces()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rapidapi.p.rapidapi.com/apiservices/autosuggest/v1.0/UK/GBP/en-GB/?query=Stockholm"),
                Headers =
                {
                    { "x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com" },
                    { "x-rapidapi-key", "97661b7ec3mshd2fbff1d04efa8ap1b7b5cjsnc539884fce8a" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var ii = JsonConvert.DeserializeObject<Test>(body);
                //Console.WriteLine(body);
            }
        }
    }
}
