using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace Airport.Data.Common
{
    public abstract class UniqueEntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
    }
}
