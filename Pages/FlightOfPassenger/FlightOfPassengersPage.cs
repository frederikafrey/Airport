using System.Collections.Generic;
using Airport.Data.FlightOfPassenger;
using Airport.Data.Passenger;
using Airport.Data.StopOver;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Airport.Facade.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.FlightOfPassenger
{
    public abstract class FlightOfPassengersPage : CommonPage<IFlightOfPassengersRepository, Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerView, FlightOfPassengerData>
    {
        protected internal FlightOfPassengersPage(IFlightOfPassengersRepository r, IStopOversRepository p, IPassengersRepository t) : base(r)
        {
            PageTitle = "Flight Of Passengers";
            StopOvers = CreateSelectList<Domain.StopOver.StopOver, StopOverData>(p);
            Passengers = CreateSelectList<Domain.Passenger.Passenger, PassengerData>(t);
        }
        public IEnumerable<SelectListItem> StopOvers { get; }
        public IEnumerable<SelectListItem> Passengers { get; }

        //public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/FlightOfPassenger/FlightOfPassengers";

        public override Domain.FlightOfPassenger.FlightOfPassenger ToObject(FlightOfPassengerView view)
            => FlightOfPassengerViewFactory.Create(view);

        public override FlightOfPassengerView ToView(Domain.FlightOfPassenger.FlightOfPassenger obj)
            => FlightOfPassengerViewFactory.Create(obj);

        public string GetStopOverName(string stopOverId)
        {
            foreach (var m in StopOvers)
                if (m.Value == stopOverId)
                    return m.Text;

            return "";
        }
        public string GetFlightOfPassengerName(string passengerId)
        {
            foreach (var m in Passengers)
                if (m.Value == passengerId)
                    return m.Text;

            return "";
        }

        public override string GetPageSubTitle()
            => FixedValue is null
                ? base.GetPageSubTitle()
                : $"{GetStopOverName(FixedValue)}";
    }
}
