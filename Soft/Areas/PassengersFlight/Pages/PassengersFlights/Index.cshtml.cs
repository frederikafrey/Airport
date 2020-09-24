using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.PassengersFlight;
using Airport.Infra;
using Airport.Pages.PassengersFlight;
using Airport.Domain.PassengersFlight;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class IndexModel : PassengersFlightsPage
    {
        public IndexModel(IPassengersFlightsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
