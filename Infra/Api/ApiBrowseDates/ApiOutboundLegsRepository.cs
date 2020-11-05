using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiQuote.ApiOutboundLeg;
using Airport.Domain.Api;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiOutboundLegsRepository : ApiCommonRepository<ApiOutboundLegData>, IApiCommonRepository<ApiOutboundLegData, ApiOutboundLegProperties>
    {
        public ApiOutboundLegsRepository()
        {
            var ee = jsonRepoData as ApiOutboundLegData;
        }

        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

        public ApiOutboundLegProperties Get(string id)
        {
            var ee = jsonRepoData as ApiOutboundLegData;
            return ee.outboundLegs.FirstOrDefault(x => x.DepartureDate == id);
        }

        public async Task<IEnumerable<ApiOutboundLegProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiOutboundLegData;
            ee.outboundLegs.Clear();
            var data = await CreateApiConnection();
            data.outboundLegs.ForEach(x => ee.outboundLegs.Add(x));
            return ee.outboundLegs;
        }
    }
}
