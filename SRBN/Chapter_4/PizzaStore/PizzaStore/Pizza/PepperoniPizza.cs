using System;

namespace PizzaStore.Pizza
{
    class PepperoniPizza : APizza
    {
        public PepperoniPizza()
        {
            Name = "Simple Pepperoni Pizza";
            Dough = "Simple Dough";
            Sauce = "Simple Sauce";
            Toppings.Add("Pepperoni");
        }
    }
}
