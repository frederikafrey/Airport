using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Luggage
{
    public sealed class LuggageView : UniqueEntityView
    {
        public string Dimensions { get; set; }
        public string Weight { get; set; }
    }
}
