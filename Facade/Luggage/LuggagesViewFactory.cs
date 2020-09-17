using Airport.Aids;
using Airport.Data.Luggage;

namespace Airport.Facade.Luggage
{
    public static class LuggagesViewFactory
    {
        public static Domain.Luggage.Luggage Create(LuggagesView view)
        {
            var d = new LuggageData();
            Copy.Members(view, d);

            return new Domain.Luggage.Luggage(d);
        }

        public static LuggagesView Create(Domain.Luggage.Luggage o)
        {
            var v = new LuggagesView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
