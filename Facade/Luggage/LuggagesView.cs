using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Luggage
{
    public sealed class LuggagesView : UniqueEntityView
    {
        [Required]
        [DisplayName("Owner")]
        public string PassengerId { get; set; }
        public int Dimensions { get; set; }
        public int Weight { get; set; }
    }
}
