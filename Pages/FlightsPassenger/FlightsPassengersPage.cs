﻿using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.PassengersFlight;
using Airport.Facade.FlightsPassenger;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.FlightsPassenger
{
    public abstract class FlightsPassengerPage : CommonPage<IFlightsPassengersRepository, Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerView, FlightsPassengerData>
    {
        protected internal FlightsPassengerPage(IFlightsPassengersRepository r, IFlightsRepository p, IPassengersFlightsRepository t) : base(r)
        {
            PageTitle = "Flight Passengers";
            Flights = CreateSelectList2<Domain.Flight.Flight, FlightData>(p);
            PassengersFlights = CreateSelectList<Domain.PassengersFlight.PassengersFlight, PassengersFlightData>(t);
        }
        public IEnumerable<SelectListItem> Flights { get; }
        public IEnumerable<SelectListItem> PassengersFlights { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/FlightsPassenger/FlightsPassengers";

        public override Domain.FlightsPassenger.FlightsPassenger ToObject(FlightsPassengerView view) => FlightsPassengerViewFactory.Create(view);
        public override FlightsPassengerView ToView(Domain.FlightsPassenger.FlightsPassenger obj) => FlightsPassengerViewFactory.Create(obj);
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
