using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Luggage;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class EditModel : LuggagesPage
    {
        public EditModel(ILuggagesRepository r, IFlightOfPassengersRepository p) : base(r, p) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await UpdateObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
