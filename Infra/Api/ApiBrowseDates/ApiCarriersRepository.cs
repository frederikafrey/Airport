using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiCarrier;
using Airport.Data.Api.ApiCurrency;
using Airport.Domain.Api;
using Newtonsoft.Json;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiCarriersRepository: ApiCommonReporitory<ApiCarrierData>, IApiCommonRepository<ApiCarrierData, ApiCarrierProperties>
    {
        public ApiCarriersRepository()
        {
            var ee = jsonRepoData as ApiCarrierData;
        }
        protected override string url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";
        protected override string host => "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        protected override string key => "90d24628bdmsh2d12c093a69ca11p1bec1djsn596101fa32da";

        #region stuff
        //public ApiCarrierProperties Get(string id)
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
        #endregion

        public ApiCarrierProperties Get(string id)
        {
            var ee = jsonRepoData as ApiCarrierData;
            return ee.carriers.FirstOrDefault(x => x.Name == id);
        }

        public async Task<IEnumerable<ApiCarrierProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiCarrierData;
            ee.carriers.Clear();
            var data = await createApiConnection();
            data.carriers.ForEach(x => ee.carriers.Add(x));
            return ee.carriers;
        }
    }
}
