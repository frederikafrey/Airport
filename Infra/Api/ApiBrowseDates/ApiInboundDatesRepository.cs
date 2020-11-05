using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiDate.ApiInboundDate;
using Airport.Domain.Api;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiInboundDatesRepository: ApiCommonRepository<ApiInboundDateData>, IApiCommonRepository<ApiInboundDateData, ApiInboundDateProperties>
    {
        public ApiInboundDatesRepository()
        {
            var ee = jsonRepoData as ApiInboundDateData;
        }

        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

        public ApiInboundDateProperties Get(string id)
        {
            var ee = jsonRepoData as ApiInboundDateData;
            return ee.inboundDates.FirstOrDefault(x => x.PartialDate == id);
        }

        public async Task<IEnumerable<ApiInboundDateProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiInboundDateData;
            ee.inboundDates.Clear();
            var data = await CreateApiConnection();
            data.inboundDates.ForEach(x => ee.inboundDates.Add(x));
            return ee.inboundDates;
        }
    }
}
