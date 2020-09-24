using System.Threading.Tasks;
using Airport.Pages.Passenger;
using Airport.Domain.Passenger;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class IndexModel : PassengersPage
    {
        public IndexModel(IPassengersRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
