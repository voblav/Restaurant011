using System;
using System.ComponentModel.DataAnnotations.Schema;
using Rest.DomainAbstractions.Entities;

namespace Rest.Entities.Code
{
    [Table("Orders")]
    public class Order: DbEntity
    {
        public DateTime Date { get; set; };
        public int NumTable { get; set; };
        public decimal TotalSum { get; set; };
        public string Annotation { get; set; };

        public virtual Steward Steward { get; set; }
        public virtual OrderFromMenu OrderFromMenu { get; set; }
    }
}
