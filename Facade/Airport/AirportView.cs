using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Airport
{
    public sealed class AirportView : UniqueEntityView 
    {
        [Required]
        [DisplayName("Webpage")]
        [DataType(DataType.Url)]
        [Url]
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
