using System.ComponentModel.DataAnnotations.Schema;
using Rest.DomainAbstractions.Entities;

namespace Rest.Entities.Code
{
    [Table("Stewards")]
    public class Steward: DbEntity
    {
        public string FirstLastName { get; set; }

        public virtual Order Order { get; set; }
    }
}
