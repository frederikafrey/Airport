using Airport.Aids;
using Airport.Data.Luggage;

namespace Airport.Facade.Luggage
{
    public static class LuggageViewFactory
    {
        public static Domain.Luggage.Luggage Create(LuggageView view)
        {
            var d = new LuggageData();
            Copy.Members(view, d);

            return new Domain.Luggage.Luggage(d);
        }

        public static LuggageView Create(Domain.Luggage.Luggage o)
        {
            var v = new LuggageView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
