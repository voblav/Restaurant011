using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Repositories
{
    public class DishesRepository :DbRepository<Dish>, IDishesRepository
    {
        public DishesRepository(MyAppDbContext context)
            : base(context)
        {

        }

        public class CompositionsRepository : DbRepository<Composition>, ICompositionsRepository
        {
            public CompositionsRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class IngredientsRepository : DbRepository<Ingredient>, IIngredientsRepository
        {
            public IngredientsRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class OrdersRepository : DbRepository<Order>, IOrdersRepository
        {
            public OrdersRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class OrderFromMenuesRepository : DbRepository<OrderFromMenu>, IOrderFromMenuesRepository
        {
            public OrderFromMenuesRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class PurchasersRepository : DbRepository<Purchaser>, IPurchasersRepository
        {
            public PurchasersRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class StewardRepository : DbRepository<Steward>, IStewardsRepository
        {
            public StewardRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }

        public class SuppleRepository : DbRepository<Supple>, ISuppliesRepository
        {
            public SuppleRepository(MyAppDbContext context)
                : base(context)
            {

            }
        }
    }
}
