using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class CreateModel : FlightsPage
    {
        private readonly IApiCitiesRepository cR;

        public CreateModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r, c, p)
        {
            cR = p;

        }

        public IActionResult OnGet(string fixedFilter, string fixedValue, string selectedName)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;

            if (selectedName != string.Empty)
            {
               // var uu = CreateSelectList(cR, selectedName);
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }

        //[HttpPost]
        //public ActionResult GetCityByStateId(int stateid)
        //{
        //   var uu =  Cities.Where(m => m. == stateid).ToList();
        //    SelectList obgcity = new SelectList(objcity, "Id", "CityName", 0);
        //    return new JsonResult(obgcity);
        //}
    }

}
