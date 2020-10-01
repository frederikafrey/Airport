﻿using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class CreateModel : StopOversPage
    {
        public CreateModel(IStopOversRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}