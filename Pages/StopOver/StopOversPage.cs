using System.Collections.Generic;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.StopOver;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Facade.StopOver;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.StopOver
{
    public abstract class StopOversPage : CommonPage<IStopOversRepository, Domain.StopOver.StopOver, StopOverView, StopOverData>
    {
        protected internal StopOversPage(IStopOversRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r)
        {
            PageTitle = "Stop Overs";
            Flights = CreateSelectList2<Domain.Flight.Flight, FlightData>(p);
            FlightOfPassengers = CreateSelectList<Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>(t);
        }
        public IEnumerable<SelectListItem> Flights { get; }
        public IEnumerable<SelectListItem> FlightOfPassengers { get; }
        public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/StopOver/StopOvers";

        public override Domain.StopOver.StopOver ToObject(StopOverView view)
            => StopOverViewFactory.Create(view);

        public override StopOverView ToView(Domain.StopOver.StopOver obj)
            => StopOverViewFactory.Create(obj);

        public string GetFlightName(string flightId)
        {
            foreach (var m in Flights)
                if (m.Value == flightId)
                    return m.Text;

            return "";
        }
        public string GetFlightOfPassengerName(string flightOfPassengerId)
        {
            foreach (var m in FlightOfPassengers)
                if (m.Value == flightOfPassengerId)
                    return m.Text;

            return "";
        }

        public override string GetPageSubTitle()
            => FixedValue is null
                ? base.GetPageSubTitle()
                : $"{GetFlightName(FixedValue)}";
    }
}
