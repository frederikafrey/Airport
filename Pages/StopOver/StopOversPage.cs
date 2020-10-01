using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.StopOver;
using Airport.Domain.Common;
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
            FlightId = CreateSelectList2<Domain.Flight.Flight, FlightData>(p);
            FlightOfPassengerId = CreateSelectList<Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>(t);
        }
        public IEnumerable<SelectListItem> FlightId { get; }
        public IEnumerable<SelectListItem> FlightOfPassengerId { get; }
        public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/StopOver/StopOvers";

        //public override Domain.StopOver.StopOver ToObject(StopOverView ofFlightView) => StopOverViewFactory.Create(ofFlightView);
        //public override StopOverView ToView(Domain.StopOver.StopOver obj) => StopOverViewFactory.Create(obj);
        //protected new static IEnumerable<SelectListItem> CreateSelectList2<TTDomain, TTData>(IRepository<TTDomain> r)
        //    where TTDomain : Entity<TTData>
        //    where TTData : UniqueEntityData, new()
        //{
        //    var items = r.Get().GetAwaiter().GetResult();

        //    return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        //}
        //protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
        //    where TTDomain : Entity<TTData>
        //    where TTData : UniqueEntityData, new()
        //{
        //    var items = r.Get().GetAwaiter().GetResult();

        //    return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        //}

        public override Domain.StopOver.StopOver ToObject(StopOverView view)
            => StopOverViewFactory.Create(view);

        public override StopOverView ToView(Domain.StopOver.StopOver obj)
            => StopOverViewFactory.Create(obj);

        public string GetFlightName(string flightId)
        {
            foreach (var m in FlightId)
                if (m.Value == flightId)
                    return m.Text;

            return "";
        }
        public string GetFlightOfPassengerName(string flightOfPassengerId)
        {
            foreach (var m in FlightOfPassengerId)
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
