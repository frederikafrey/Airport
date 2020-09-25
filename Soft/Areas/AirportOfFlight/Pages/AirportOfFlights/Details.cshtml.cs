﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Domain.Airport;
using Airport.Domain.AirportOfFlight;
using Airport.Infra;
using Airport.Pages.Airport;
using Airport.Pages.AirportOfFlight;

namespace Airport.Soft.Areas.AirportOfFlight.Pages.AirportOfFlights
{
    public class DetailsModel : AirportOfFlightPage
    {
        public DetailsModel(IAirportOfFlightsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}