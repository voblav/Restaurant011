using Rest.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.AppContext.Code
{
    class MyAppDbContext: DbContext
    {
        public DbSet<Composition> Compositions { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderFromMenu> OrderFromMenues { get; set; }
        public DbSet<Purchaser> Purchasers { get; set; }
        public DbSet<Steward> Stewards { get; set; }
        public DbSet<Supple> Suppliers { get; set; }

        public MyAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        static MyAppDbContext()
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
}
