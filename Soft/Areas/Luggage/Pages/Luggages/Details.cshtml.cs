using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class DetailsModel : LuggagesPage
    {
        public DetailsModel(ILuggagesRepository r, IPassengersRepository p) : base(r, p) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
