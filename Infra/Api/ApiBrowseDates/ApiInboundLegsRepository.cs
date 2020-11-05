using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiQuote.ApiInboundLeg;
using Airport.Domain.Api;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiInboundLegsRepository : ApiCommonRepository<ApiInboundLegData>, IApiCommonRepository<ApiInboundLegData, ApiInboundLegProperties>
    {
        public ApiInboundLegsRepository()
        {
            var ee = jsonRepoData as ApiInboundLegData;
        }

        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

        public ApiInboundLegProperties Get(string id)
        {
            var ee = jsonRepoData as ApiInboundLegData;
            return ee.inboundLegs.FirstOrDefault(x => x.DepartureDate == id);
        }

        public async Task<IEnumerable<ApiInboundLegProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiInboundLegData;
            ee.inboundLegs.Clear();
            var data = await CreateApiConnection();
            data.inboundLegs.ForEach(x => ee.inboundLegs.Add(x));
            return ee.inboundLegs;
        }
    }
}
