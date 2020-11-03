using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Airport.Infra.Api
{
    public abstract class ApiCommonReporitory<TData> where TData : new()
    {
        protected TData jsonRepoData = new TData();
        protected virtual string url { get; }
        protected virtual string host { get; }
        protected virtual string key { get; }

        protected async Task<TData> createApiConnection()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    {"x-rapidapi-host", host},
                    {"x-rapidapi-key", key},
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
