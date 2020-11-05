using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiDate.ApiOutboundDate;
using Airport.Domain.Api;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiOutboundDatesRepository: ApiCommonRepository<ApiOutboundDateData>, IApiCommonRepository<ApiOutboundDateData, ApiOutboundDateProperties>
    {
        public ApiOutboundDatesRepository()
        {
            var ee = jsonRepoData as ApiOutboundDateData;
        }

        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

        public ApiOutboundDateProperties Get(string id)
        {
            var ee = jsonRepoData as ApiOutboundDateData;
            return ee.outboundDates.FirstOrDefault(x => x.PartialDate == id);
        }

        public async Task<IEnumerable<ApiOutboundDateProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiOutboundDateData;
            ee.outboundDates.Clear();
            var data = await CreateApiConnection();
            data.outboundDates.ForEach(x => ee.outboundDates.Add(x));
            return ee.outboundDates;
        }
    }
}
