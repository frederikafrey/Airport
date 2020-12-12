using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class EditModel : StopOversPage
    {
        public EditModel(IStopOversRepository r, IFlightsRepository p) : base(r) { }

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
