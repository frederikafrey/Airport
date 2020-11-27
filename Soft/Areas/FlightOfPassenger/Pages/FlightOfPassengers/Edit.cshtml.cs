using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Airport.Pages.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class EditModel : FlightOfPassengersPage
    {
        public EditModel(IFlightOfPassengersRepository r, IPassengersRepository t, IFlightsRepository p, ILuggagesRepository l) : base(r, t, p, l) { }
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
