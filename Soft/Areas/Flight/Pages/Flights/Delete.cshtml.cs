using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class DeleteModel : FlightsPage
    {
        public DeleteModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r, c, p) { }
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
