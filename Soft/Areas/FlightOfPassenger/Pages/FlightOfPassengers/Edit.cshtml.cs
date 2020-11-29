using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class EditModel : FlightOfPassengersPage
    {
        public EditModel(IFlightOfPassengersRepository r, IPassengersRepository p, IFlightsRepository f, ILuggagesRepository l) : base(r, p, f, l) { }
        //IStopOversRepository p

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await UpdateObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

        public override string ItemId { get; }
    }
}
