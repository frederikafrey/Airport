﻿using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Pages.PassengerOfFlight;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.PassengerOfFlight.Pages.PassengerOfFlights
{
    public class DetailsModel : PassengerOfFlightsPage
    {
        public DetailsModel(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}