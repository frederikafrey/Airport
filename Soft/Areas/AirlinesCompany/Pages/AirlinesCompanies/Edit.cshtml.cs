using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.AirlinesCompany;
using Airport.Pages.AirlinesCompany;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class EditModel : AirlinesCompaniesPage
    {
        public EditModel(IAirlinesCompaniesRepository r) : base(r) { }
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
