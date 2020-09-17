using Airport.Facade.Common;

namespace Airport.Facade.Luggage
{
    public sealed class LuggagesView : UniqueEntityView
    {
        public string PassengerId { get; set; }
        public int Dimensions { get; set; }
        public int Weight { get; set; }
    }
}
