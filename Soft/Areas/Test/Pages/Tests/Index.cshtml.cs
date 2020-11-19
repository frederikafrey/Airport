using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Facade;
using Airport.Pages.Flight;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Soft.Areas.Test.Pages.Tests
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public async Task<ActionResult> OnGetAsync(string dd1, string ida)
        {
            List<SelectListItem> dept = new List<SelectListItem>();
            var aa = new List<Testa>() { new Testa() { Id = "0", Name = "Name1"}, new Testa() { Id = "1", Name = "Name2" } };


            aa.ForEach(y => dept.Add(new SelectListItem { Text = y.Name, Value = y.Id}));
            
            ViewData["Departments"] = dept;
            return Page();
        }

       
        public JsonResult LoadPhysiansByDepartment(string deptId)
        {
            var aa = new List<Festa>() { new Festa() { Id = "00", Name = "Fame1", TestaId = "0" }, new Festa() { Id = "01", Name = "Fame2", TestaId = "0" }, new Festa() { Id = "02", Name = "Fame3", TestaId = "1" } };
       

            var ee = aa.Where(x => x.TestaId == deptId).ToList();
            var ss = ee.Select(x => new SelectListItem { Text = x.Name, Value = x.Id });
            return new JsonResult(ss);
        }
    }
}
