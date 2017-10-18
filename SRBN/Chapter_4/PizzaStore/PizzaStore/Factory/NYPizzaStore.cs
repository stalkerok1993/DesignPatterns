using PizzaStore.Pizza;
using PizzaStore.Pizza.NYStyle;

namespace PizzaStore.Factory
{
    class NYPizzaStore : APizzaStore
    {
        public override APizza CreatePizza(PizzaType type)
        {
            APizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new NYStyleCheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new NYStylePepperoniPizza();
                    break;
                case PizzaType.Clam:
                    pizza = new NYStyleClamPizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new NYStyleVeggiePizza();
                    break;
                default:
                    pizza = new NYStyleCheesePizza();
                    break;
            }

            return pizza;
        }
    }
}
