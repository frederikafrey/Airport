using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.AirlinesCompany;
using Airport.Domain.AirlinesCompany;
using Airport.Pages.AirlinesCompany;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class IndexModel : AirlinesCompaniesPage
    {
        public IndexModel(IAirlinesCompaniesRepository r) : base(r) { }

        public IList<AirlinesCompanyData> AirlinesCompanyData { get; set; }

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
