using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Luggage;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class CreateModel : LuggagesPage
    {
        public CreateModel(ILuggagesRepository r) : base(r) { }

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
