using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.PassengerOfFlight;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Facade.PassengerOfFlight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.PassengerOfFlight
{
    public abstract class PassengerOfFlightsPage : CommonPage<IPassengerOfFlightsRepository, Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightView, PassengerOfFlightData>
    {
        protected internal PassengerOfFlightsPage(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r)
        {
            PageTitle = "Passenger Of Flights";
            Flights = CreateSelectList2<Domain.Flight.Flight, FlightData>(p);
            PassengersFlights = CreateSelectList<Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>(t);
        }
        public IEnumerable<SelectListItem> Flights { get; }
        public IEnumerable<SelectListItem> PassengersFlights { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/PassengerOfFlight/PassengerOfFlights";

        public override Domain.PassengerOfFlight.PassengerOfFlight ToObject(PassengerOfFlightView ofFlightView) => PassengerOfFlightViewFactory.Create(ofFlightView);
        public override PassengerOfFlightView ToView(Domain.PassengerOfFlight.PassengerOfFlight obj) => PassengerOfFlightViewFactory.Create(obj);
        protected new static IEnumerable<SelectListItem> CreateSelectList2<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
        protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
    }
}
