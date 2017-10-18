using System;

namespace PizzaStore.Pizza.ChicagoStyle
{
    class ChicagoStyleCheesePizza : APizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }
        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
