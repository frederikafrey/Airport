using System.Threading.Tasks;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Flight;
using Airport.Domain.StopOver;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class IndexModel : FlightsPage
    {
        private IApiCitiesRepository citiesRepository;
        private IApiCountriesRepository countriesRepository;
        
        public IndexModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s) : base(r, c, p, s)
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
