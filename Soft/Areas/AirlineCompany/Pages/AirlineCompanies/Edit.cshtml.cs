using System.Threading.Tasks;
using Airport.Domain.AirlineCompany;
using Airport.Pages.AirlineCompany;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.AirlineCompany.Pages.AirlineCompanies
{
    public class EditModel : AirlineCompaniesPage
    {
        public EditModel(IAirlineCompaniesRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
