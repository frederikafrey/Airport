﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class CreateModel : LuggagesPage
    {
        public CreateModel(ILuggagesRepository r, IPassengersRepository p) : base(r, p) { }

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
