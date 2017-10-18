using PizzaStore.Pizza;
using PizzaStore.Pizza.ChicagoStyle;

namespace PizzaStore.Factory
{
    class ChicagoPizzaStore : APizzaStore
    {
        public override APizza CreatePizza(PizzaType type)
        {
            APizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case PizzaType.Clam:
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                default:
                    pizza = new ChicagoStyleCheesePizza();
                    break;
            }
            
            return pizza;
        }
    }
}
