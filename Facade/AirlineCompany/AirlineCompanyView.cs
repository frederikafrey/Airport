using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.AirlineCompany
{
    public sealed class AirlineCompanyView : UniqueEntityView 
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
