﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Flight;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Flight;
using Airport.Infra;
using Airport.Pages.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class EditModel : FlightsPage
    {
        public EditModel(IFlightsRepository r, IAirlineCompaniesRepository t) : base(r, t) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
