using System.Threading.Tasks;
using Airport.Domain.AirlinesCompany;
using Airport.Pages.AirlinesCompany;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class IndexModel : AirlinesCompaniesPage
    {
        public IndexModel(IAirlinesCompaniesRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
