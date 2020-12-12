using Airport.Data.StopOver;
using Airport.Domain.StopOver;
using Airport.Facade.StopOver;

namespace Airport.Pages.StopOver
{
    public abstract class StopOversPage : CommonPage<IStopOversRepository, Domain.StopOver.StopOver, StopOverView, StopOverData>
    {
        protected internal StopOversPage(IStopOversRepository r) : base(r)
        {
            PageTitle = "Stop Overs";
        }
        public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/StopOver/StopOvers";

        public override Domain.StopOver.StopOver ToObject(StopOverView view)
            => StopOverViewFactory.Create(view);

        public override StopOverView ToView(Domain.StopOver.StopOver obj)
            => StopOverViewFactory.Create(obj);
    }
}
