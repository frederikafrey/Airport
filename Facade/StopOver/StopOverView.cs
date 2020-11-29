using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.StopOver
{
    public sealed class StopOverView : UniqueEntityView
    {
        [Required]
        [DisplayName("Country")]
        public string Country { get; set; }

        [Required]
        [DisplayName("City")]
        public string City { get; set; }

        public string GetId() => $"{Country}.{City}";
    }
}
