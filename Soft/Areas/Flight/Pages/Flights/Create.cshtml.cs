using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Pages.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Airport.Data.Api.ApiCountry;
using System;

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
        [HttpPost]
        public JsonResult ListOfCitiesByCountryId(string countryId)
        {
          
            return new JsonResult(countryId);
        }

        ////[AcceptVerbs(HttpVerbs.Get)]
        //public JsonResult GETSubType(string Typeid)
        //{


        //    return new JsonResult(Typeid);

        //}
        public List<SelectListItem> ProjectType_SubTypeList(string id)
        {
            return new List<SelectListItem>();
            //var subtypes = from u in db.SubType where u.ProjectTypeID == id.ToString() select u;
            //List<SelectListItem> ProjectsubTypes = new List<SelectListItem>();
            //ProjectsubTypes.Clear();
            ////   ProjectsubTypes.Add(new SelectListItem { Text = "--Select Project sub-Type--", Value = "0" });
            //if (subtypes != null)
            //{
            //    foreach (var subtype in subtypes)
            //    {
            //        ProjectsubTypes.Add(new SelectListItem { Text = subtype.name, Value = subtype.id.ToString() });
            //    }
            //}
            //return ProjectsubTypes;
        }
    }
}
