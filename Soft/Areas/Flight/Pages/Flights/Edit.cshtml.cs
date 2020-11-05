using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class EditModel : FlightsPage
    {
        public EditModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r, c, p) { }

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
