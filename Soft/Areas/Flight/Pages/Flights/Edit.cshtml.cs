using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using Airport.Domain.StopOver;
using Airport.Domain.AirlineCompany;
using System.IO;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class EditModel : FlightsPage
    {
        private readonly IApiCitiesRepository cR;

        public EditModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s, IAirlineCompaniesRepository ac) : base(r, c, p, s, ac) 
        { 
            cR = p; 
        }

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
        public async Task<IActionResult> OnPostCities()
        {
            var stream = new MemoryStream();
            await Request.Body.CopyToAsync(stream);
            stream.Position = 0;

            using var reader = new StreamReader(stream);
            var body = reader.ReadToEnd();
            if (body.Length <= 0) return new JsonResult(new { Success = false });
            var cities = CreateSelectList(cR, body);

            return new JsonResult(cities);
        }
    }
}
