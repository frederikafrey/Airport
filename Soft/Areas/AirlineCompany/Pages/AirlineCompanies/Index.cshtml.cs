using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.AirlineCompany;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Api;
using Airport.Domain.Api.ApiCarrier;
using Airport.Pages.AirlineCompany;

namespace Airport.Soft.Areas.AirlineCompany.Pages.AirlineCompanies
{
    public class IndexModel : AirlineCompaniesPage
    {
        public IndexModel(IAirlineCompaniesRepository r) : base(r) { }

        public IList<AirlineCompanyData> AirlinesCompanyData { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
