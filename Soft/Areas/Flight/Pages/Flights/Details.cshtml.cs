﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using Airport.Domain.StopOver;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class DetailsModel : FlightsPage
    {
        public DetailsModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s) : base(r, c, p, s) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
