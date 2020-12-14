using System.Threading.Tasks;
using Airport.Domain.AirlineCompany;
using Airport.Pages.AirlineCompany;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.AirlineCompany.Pages.AirlineCompanies
{
    public class CreateModel : AirlineCompaniesPage
    {

        public CreateModel(IAirlineCompaniesRepository r) : base(r) { }

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
    }
}
