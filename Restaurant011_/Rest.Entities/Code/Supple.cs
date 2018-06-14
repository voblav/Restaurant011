using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Entities.Code
{
    [Table("Supplies")]
    public class Supple
    {
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }

        public virtual List<Purchaser> Purchasers { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
