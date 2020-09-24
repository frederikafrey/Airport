using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Data.Flight;
using Airport.Domain.AirlinesCompany;
using Airport.Domain.Flight;
using Airport.Infra;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class CreateModel : FlightsPage
    {
        public CreateModel(IFlightsRepository r, IAirlinesCompaniesRepository t) : base(r, t) { }

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
