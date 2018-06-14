using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Entities.Code
{
    [Table("Composition")]
    public class Composition
    {
        public decimal Quantity { get; set; }

        public virtual Dish Dish { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }

    }
}
