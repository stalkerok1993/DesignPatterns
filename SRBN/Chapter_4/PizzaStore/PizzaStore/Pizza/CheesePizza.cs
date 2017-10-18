using System;

namespace PizzaStore.Pizza
{
    class CheesePizza : APizza
    {
        public CheesePizza()
        {
            Name = "Simple Cheese Pizza";
            Dough = "Simple Dough";
            Sauce = "Simple Sauce";
            Toppings.Add("Chese");
        }
    }
}
