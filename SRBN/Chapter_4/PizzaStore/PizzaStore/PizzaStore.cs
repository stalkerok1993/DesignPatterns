using PizzaStore.Factory;
using PizzaStore.Pizza;
using System;

namespace PizzaStore
{
    class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public IPizza orderPizza(String type)
        {
            IPizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
