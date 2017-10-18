using PizzaStore.Pizza;
using PizzaStore.Pizza.CaliforniaStyle;

namespace PizzaStore.Factory
{
    class CaliforniaPizzaStore : APizzaStore
    {
        public override APizza CreatePizza(PizzaType type)
        {
            APizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CaliforniaStyleCheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new CaliforniaStylePepperoniPizza();
                    break;
                case PizzaType.Clam:
                    pizza = new CaliforniaStyleClamPizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new CaliforniaStyleVeggiePizza();
                    break;
                default:
                    pizza = new CaliforniaStyleCheesePizza();
                    break;
            }

            return pizza;
        }
    }
}
