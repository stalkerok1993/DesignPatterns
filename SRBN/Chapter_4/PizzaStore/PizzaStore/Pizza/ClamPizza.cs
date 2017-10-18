using System;

namespace PizzaStore.Pizza
{
    class ClamPizza : APizza
    {
        public ClamPizza()
        {
            Name = "Simple Clam Pizza";
            Dough = "Simple Dough";
            Sauce = "Simple Sauce";
            Toppings.Add("Clam");
        }
    }
}
