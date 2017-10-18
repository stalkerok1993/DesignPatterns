using PizzaStore.Factory;
using PizzaStore.Pizza;
using System;

namespace PizzaStore.Factory
{
    abstract class APizzaStore
    {
        public APizza OrderPizza(PizzaType type)
        {
            APizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract APizza CreatePizza(PizzaType type);
    }
}
