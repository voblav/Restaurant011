using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Entities.Code
{
    [Table("Ingredients")]
    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Costprice { get; set; }
        public string Units { get; set; }

        public List<Supple> Supplies { get; set; }
    }
}
