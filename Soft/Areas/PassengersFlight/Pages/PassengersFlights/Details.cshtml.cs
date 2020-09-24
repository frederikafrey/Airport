using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.PassengersFlight;
using Airport.Domain.PassengersFlight;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class DetailsModel : PassengersFlightsPage
    {
        public DetailsModel(IPassengersFlightsRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
