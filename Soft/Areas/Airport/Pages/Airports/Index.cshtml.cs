using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class IndexModel : AirportsPage
    {
        private IApiPlacesRepository placesRepository;
        private IApiCountriesRepository countriesRepository;

        public IndexModel(IAirportsRepository r, IApiPlacesRepository p, IApiCountriesRepository c) : base(r)
        {
            placesRepository = p;
            countriesRepository = c;
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            var bb = await countriesRepository.GetAll();
            var ee = bb.ElementAt(105);
            var qq = await placesRepository.GetAll(ee.Name);
            var aa = await placesRepository.GetAll();
            await GetList(sortOrder, currentFilter, searchString, pageIndex, 
                fixedFilter, fixedValue);
        }
    }
}
