using Airport.Infra.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace Airport.Tests.Infra.Api
{
    [TestClass]
    public class ApiCommonRepositoryTests : BaseRepositoryTests
    {
        //protected TData jsonRepoData;

        //public HttpMethod Method { get; private set; }
        //public Uri RequestUri { get; private set; }
        //protected virtual string Url { get; }
        //protected string Host => "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        //protected virtual string Key => "90d24628bdmsh2d12c093a69ca11p1bec1djsn596101fa32da";

        //[TestMethod]
        //public void TestCreateApiConnection()
        //{
        //    var client = new HttpClient();
        //    var request = new HttpRequestMessage();

        //    Method = HttpMethod.Get;
        //    RequestUri = new Uri(Url);

        //    Assert.AreEqual(Url.ToString(), "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/reference/v1.0/countries/en-US"); 

        }
        
        //    protected async Task<TData> CreateApiConnection()
        //    {
        //        var client = new HttpClient();
        //        var request = new HttpRequestMessage
        //        {
        //            Method = HttpMethod.Get,
        //            RequestUri = new Uri(Url),
        //            Headers =
        //            {
        //                {"x-rapidapi-Host", Host},
        //                {"x-rapidapi-Key", Key},
        //            },
        //        };

        //        using (var response = await client.SendAsync(request))
        //        {
        //            response.EnsureSuccessStatusCode();
        //            var body = await response.Content.ReadAsStringAsync();
        //            return JsonConvert.DeserializeObject<TData>(body);
        //        }
        //    }
        //}
    }

