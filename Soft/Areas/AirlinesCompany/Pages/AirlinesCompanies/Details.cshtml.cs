using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.AirlinesCompany;
using Airport.Pages.AirlinesCompany;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class DetailsModel : AirlinesCompaniesPage
    {
        public DetailsModel(IAirlinesCompaniesRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
