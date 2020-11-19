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
using Airport.Facade;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class CreateModel : FlightsPage
    {
        private readonly IApiCitiesRepository cR;

        public CreateModel(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r, c, p)
        {
            cR = p;

        }

        public IActionResult OnGet(string fixedFilter, string fixedValue, string selectedName, string deptId)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;

            if (selectedName != string.Empty)
            {
                // var uu = CreateSelectList(cR, selectedName);
            }
            List<SelectListItem> dept = new List<SelectListItem>();
            var aa = new List<Testa>() { new Testa() { Id = "0", Name = "Name1" }, new Testa() { Id = "1", Name = "Name2" } };


            aa.ForEach(y => dept.Add(new SelectListItem { Text = y.Name, Value = y.Id }));

            ViewData["Departments"] = dept;
            return Page();
        }
        [Route("api/LoadPhysiansByDepartment/{deptId}")]
        public IActionResult LoadPhysiansByDepartment(string deptId)
        {
            var aa = new List<Festa>() { new Festa() { Id = "00", Name = "Fame1", TestaId = "0" }, new Festa() { Id = "01", Name = "Fame2", TestaId = "0" }, new Festa() { Id = "02", Name = "Fame3", TestaId = "1" } };


            var ee = aa.Where(x => x.TestaId == deptId).ToList();
            var ss = ee.Select(x => new SelectListItem { Text = x.Name, Value = x.Id });
            return new JsonResult(ss);
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
