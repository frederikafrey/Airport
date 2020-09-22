using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Airport;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class CreateModel : AirportsPage
    {
        public CreateModel(IAirportsRepository r) : base(r) { }
        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue))
            {
                return Page();
            }
            return Redirect(IndexUrl);
        }
    }
}
