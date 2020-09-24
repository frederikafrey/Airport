using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.Passenger;
using Airport.Domain.Passenger;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class DeleteModel : PassengersPage
    {
        public DeleteModel(IPassengersRepository r) : base(r) { }
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
