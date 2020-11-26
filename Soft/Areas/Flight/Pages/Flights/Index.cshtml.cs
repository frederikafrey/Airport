﻿using System.Linq;
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
           // var qq = await citiesRepository.Get();
            //var aa = await citiesRepository.GetAll();
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
            var ww = Items.ElementAt(0).StartCity;
            var eee = citiesRepository.Get(ww);
            //Items.ToList().ForEach(x => x.FinalCity = citiesRepository.Get(x.FinalCity).PlaceName);
        }
    }
}
