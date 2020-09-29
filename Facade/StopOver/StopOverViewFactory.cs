using Airport.Aids;
using Airport.Data.StopOver;

namespace Airport.Facade.StopOver
{
    public static class StopOverViewFactory
    {
        public static Domain.StopOver.StopOver Create(StopOverView ofFlightView)
        {
            var d = new StopOverData();
            Copy.Members(ofFlightView, d);

            return new Domain.StopOver.StopOver(d);
        }

        public static StopOverView Create(Domain.StopOver.StopOver o)
        {
            var v = new StopOverView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
