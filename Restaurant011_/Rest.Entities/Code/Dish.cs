
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Entities.Code
{
    [Table("Dishes")]
    public class Dish
    {
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Price { get; set; }
        public string Preparation { get; set; }

        public virtual OrderFromMenu OrderFromMenu { get; set; }
        public virtual Composition Composition { get; set; }
    }
}
