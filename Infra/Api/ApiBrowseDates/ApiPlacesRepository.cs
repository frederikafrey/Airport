using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiPlace;
using Airport.Domain.Api;

namespace Airport.Infra.Api.ApiBrowseDates
{
    public class ApiPlacesRepository : ApiCommonRepository<ApiPlaceData>, IApiCommonRepository<ApiPlaceData, ApiPlaceProperties>
    {
        public ApiPlacesRepository()
        {
            var ee = jsonRepoData as ApiPlaceData;
        }

        protected override string Url => "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01";

        public ApiPlaceProperties Get(string id)
        {
            var ee = jsonRepoData as ApiPlaceData;
            return ee.places.FirstOrDefault(x => x.Name == id);
        }

        public async Task<IEnumerable<ApiPlaceProperties>> GetAll()
        {
            var ee = jsonRepoData as ApiPlaceData;
            ee.places.Clear();
            var data = await CreateApiConnection();
            data.places.ForEach(x => ee.places.Add(x));
            return ee.places;
        }
    }
}
