using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using System.IO;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.StopOver;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class CreateModel : FlightsPage
    {
        private readonly IApiCitiesRepository cR;

        public CreateModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s) : base(r, c, p, s)
        {
            cR = p;
        }

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

        public async Task<IActionResult> OnPostCities()
        {
            var stream = new MemoryStream();
            await Request.Body.CopyToAsync(stream);
            stream.Position = 0;

            using var reader = new StreamReader(stream);
            var body = reader.ReadToEnd();
            if (body.Length <= 0) return new JsonResult(new {Success = false});
            var cities = CreateSelectList(cR, body);

            return new JsonResult(cities);
        }
    }
}
