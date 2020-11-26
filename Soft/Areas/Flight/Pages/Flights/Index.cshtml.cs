using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class IndexModel : FlightsPage
    {
        private IApiCitiesRepository citiesRepository;
        private IApiCountriesRepository countriesRepository;
        
        public IndexModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r, c, p)
        {
            citiesRepository = p;
            countriesRepository = c;
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
