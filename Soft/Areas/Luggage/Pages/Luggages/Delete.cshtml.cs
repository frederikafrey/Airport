using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class DeleteModel : LuggagesPage
    {
        public DeleteModel(ILuggagesRepository l, IPassengersRepository p) : base(l, p) { }
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
