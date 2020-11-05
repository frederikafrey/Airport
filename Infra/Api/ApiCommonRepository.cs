using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public abstract class ApiCommonRepository<TData> where TData : new()
    {
        protected TData jsonRepoData = new TData();
        protected virtual string Url { get; }
        protected string Host => "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        protected virtual string Key => "90d24628bdmsh2d12c093a69ca11p1bec1djsn596101fa32da";

        protected async Task<TData> CreateApiConnection()
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
                return JsonConvert.DeserializeObject<TData>(body);
            }
        }

        //public TData Get(string id)
        //{
        //    return _apiCarrierData.carriers.FirstOrDefault(x => x.Name == id);
        //}

        //public async Task<IEnumerable<ApiCarrierProperties>> GetAll()
        //{
        //    _apiCarrierData.carriers.Clear();
        //    var data = await ApiConnection();
        //    data.carriers.ForEach(x => _apiCarrierData.carriers.Add(x));
        //    return _apiCarrierData.carriers;
        //}
    }
}
