﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.AirlinesCompany;
using Airport.Pages.AirlinesCompany;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class CreateModel : AirlinesCompaniesPage
    {
        public CreateModel(IAirlinesCompaniesRepository r) : base(r) { }

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
