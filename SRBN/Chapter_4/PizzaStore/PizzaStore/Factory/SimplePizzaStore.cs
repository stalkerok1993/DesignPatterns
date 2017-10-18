using PizzaStore.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Factory
{
    class SimplePizzaStore
    {
        private SimplePizzaFactory factory;

        public SimplePizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public APizza OrderPizza(String type)
        {
            APizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
