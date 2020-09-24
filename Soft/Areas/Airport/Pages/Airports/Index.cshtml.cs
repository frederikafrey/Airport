using System.Threading.Tasks;
using Airport.Domain.Airport;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class IndexModel : AirportsPage
    {
        public IndexModel(IAirportsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex, 
                fixedFilter, fixedValue);
        }
    }
}
