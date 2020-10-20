using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class IndexModel : AirportsPage
    {
        private IApiPlacesRepository pR;
        private IApiCountriesRepository cR;

        public IndexModel(IAirportsRepository r, IApiPlacesRepository p, IApiCountriesRepository c) : base(r)
        {
            pR = p;
            cR = c;
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            var bb = await cR.GetAll();
            var ee = bb.Countries.ElementAt(105);
            var qq = await pR.GetAll(ee.Name);
            var aa = await pR.GetAll();
            await GetList(sortOrder, currentFilter, searchString, pageIndex, 
                fixedFilter, fixedValue);
        }
    }
}
