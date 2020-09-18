using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Passenger
{
    public sealed class PassengerView : UniqueEntityView
    {
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Age")]
        [Range(1, 90, ErrorMessage = "Customer {0} should be in {1} to {2} range.")]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Address { get; set; }
    }
}
