using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Entities.Code
{
    [Table("OrderFromMenu")]
    public class OrderFromMenu
    {
        public decimal Entity { get; set; }
        public decimal Sum { get; set; }

        public virtual Order Order { get; set; }
        public virtual List<Dish> Dishes { get; set; }
    }
}
