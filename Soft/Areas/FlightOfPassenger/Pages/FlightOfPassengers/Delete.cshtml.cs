using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.FlightOfPassenger;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class DeleteModel : FlightOfPassengersPage
    {
        public DeleteModel(IFlightOfPassengersRepository r, IPassengersRepository t, IFlightsRepository p, ILuggagesRepository l) : base(r, t, p, l) { }
        //IStopOversRepository p
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

        public override string ItemId { get; }
    }
}
