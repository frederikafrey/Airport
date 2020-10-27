using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data.Flight;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class IndexModel : FlightsPage
    {
        private IApiPlacesRepository placesRepository;
        private IApiCountriesRepository countriesRepository;

        public IndexModel(IFlightsRepository r, IApiPlacesRepository p, IApiCountriesRepository c) : base(r, c)
        {
            placesRepository = p;
            countriesRepository = c;
        }

        //public IList<FlightData> FlightData { get; set; }

        //public async Task OnGetAsync(string sortOrder,
        //    string id, string currentFilter, string searchString, int? pageIndex,
        //    string fixedFilter, string fixedValue)
        //{
        //    SelectedId = id;
        //    await GetList(sortOrder, currentFilter, searchString, pageIndex,
        //        fixedFilter, fixedValue);
        //}

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            var bb = await countriesRepository.GetAll();
            var ee = bb.ElementAt(105);
            //var qq = await placesRepository.GetAll(ee.Name);
            //var aa = await placesRepository.GetAll();
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
