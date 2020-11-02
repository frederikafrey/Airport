using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class CreateModel : FlightsPage
    {
        public CreateModel(IFlightsRepository r, IApiCitiesRepository p, IApiCountriesRepository c) : base(r, c, p) { }

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
