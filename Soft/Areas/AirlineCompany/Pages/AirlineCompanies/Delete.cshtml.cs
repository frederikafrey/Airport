using System.Threading.Tasks;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Api;
using Airport.Domain.Api.ApiCarrier;
using Airport.Pages.AirlineCompany;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.AirlineCompany.Pages.AirlineCompanies
{
    public class DeleteModel : AirlineCompaniesPage
    {
        public DeleteModel(IAirlineCompaniesRepository r, IApiCarriersRepository c) : base(r, c) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
