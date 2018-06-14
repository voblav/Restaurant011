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
    }
}
