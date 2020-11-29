using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class DetailsModel : FlightOfPassengersPage
    {
        public DetailsModel(IFlightOfPassengersRepository r, IPassengersRepository t, IFlightsRepository p, ILuggagesRepository l) : base(r, t, p, l) { }
        //IStopOversRepository p
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public override string ItemId { get; }
    }
}
