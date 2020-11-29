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
        public DeleteModel(IFlightOfPassengersRepository r, IPassengersRepository p, IFlightsRepository f, ILuggagesRepository l) : base(r, p, f, l) { }
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
