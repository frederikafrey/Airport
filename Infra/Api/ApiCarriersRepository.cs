using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiCarrier;
using Airport.Domain.Api;

namespace Airport.Infra.Api
{
    public class ApiCarriersRepository: ApiCommonRepository<ApiCarrierData>, IApiCarriersRepository
    {
        public ApiCarriersRepository()
        {
            var ee = jsonRepoData as ApiCarrierData;
        }
        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

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
            var data = await CreateApiConnection();
            data.carriers.ForEach(x => ee.carriers.Add(x));
            return ee.carriers;
        }
    }
}
