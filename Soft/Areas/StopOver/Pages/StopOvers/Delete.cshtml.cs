﻿using System.Threading.Tasks;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class DeleteModel : StopOversPage
    {
        public DeleteModel(IStopOversRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }

}
