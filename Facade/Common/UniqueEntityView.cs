using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Common
{
    public abstract class UniqueEntityView
    {
        [Required]
        public string Id { get; set; }
    }
}
