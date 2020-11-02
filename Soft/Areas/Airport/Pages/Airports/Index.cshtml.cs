using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class IndexModel : AirportsPage
    {
        private IApiCitiesRepository citiesRepository;
        private IApiCountriesRepository countriesRepository;

        public IndexModel(IAirportsRepository r, IApiCitiesRepository p, IApiCountriesRepository c) : base(r)
        {
            citiesRepository = p;
            countriesRepository = c;
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            var countries = await countriesRepository.GetAll();
            var chosenCountry = countries.ElementAt(105);
            var qq = await citiesRepository.GetAll(chosenCountry.Name);
            var aa = await citiesRepository.GetAll();
            await GetList(sortOrder, currentFilter, searchString, pageIndex, 
                fixedFilter, fixedValue);
        }
    }
}
