using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.Passenger;
using Airport.Domain.Passenger;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class DetailsModel : PassengersPage
    {
        public DetailsModel(IPassengersRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
