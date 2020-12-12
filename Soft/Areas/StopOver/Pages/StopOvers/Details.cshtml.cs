using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class DetailsModel : StopOversPage
    {
        public DetailsModel(IStopOversRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
