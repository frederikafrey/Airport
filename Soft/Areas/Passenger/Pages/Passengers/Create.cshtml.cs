using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.Passenger;
using Airport.Domain.Passenger;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class CreateModel : PassengersPage
    {
        public CreateModel(IPassengersRepository r) : base(r) { }

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
