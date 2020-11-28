using System.ComponentModel.DataAnnotations.Schema;

namespace Airport.Data.Common
{
    public abstract class UniqueEntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
    }
}
