using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.PassengersFlight;
using Airport.Infra;
using Airport.Pages.FlightsPassenger;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class IndexModel : FlightsPassengerPage
    {
        public IndexModel(IFlightsPassengersRepository r, IFlightsRepository p, IPassengersFlightsRepository t) : base(r, p, t) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
            => await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
    }
}
