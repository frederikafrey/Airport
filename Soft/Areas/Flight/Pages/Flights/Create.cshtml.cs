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

            //if (selectedName != string.Empty)
            //{
            //    // var uu = CreateSelectList(cR, selectedName);
            //}
            //List<SelectListItem> dept = new List<SelectListItem>();
            //var aa = new List<Testa>() { new Testa() { Id = "0", Name = "Name1" }, new Testa() { Id = "1", Name = "Name2" } };


            //aa.ForEach(y => dept.Add(new SelectListItem { Text = y.Name, Value = y.Id }));

            //ViewData["Departments"] = dept;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
