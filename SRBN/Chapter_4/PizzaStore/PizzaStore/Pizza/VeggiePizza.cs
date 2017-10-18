using System;

namespace PizzaStore.Pizza
{
    class VeggiePizza : APizza
    {
        public VeggiePizza()
        {
            Name = "Simple Veggie Pizza";
            Dough = "Simple Dough";
            Sauce = "Simple Sauce";
            Toppings.Add("Vegetables");
        }
    }
}
