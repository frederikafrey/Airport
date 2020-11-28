using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using Airport.Domain.StopOver;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class DeleteModel : FlightsPage
    {
        public DeleteModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s) : base(r, c, p, s) { }
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
