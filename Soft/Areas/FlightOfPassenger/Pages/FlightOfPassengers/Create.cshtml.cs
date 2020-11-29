using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class CreateModel : FlightOfPassengersPage
    {
        public CreateModel(IFlightOfPassengersRepository r, IPassengersRepository t, IFlightsRepository p, ILuggagesRepository l) : base(r, t, p, l) { }
        //IStopOversRepository p
        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }

        public override string ItemId { get; }
    }
}
