namespace PizzaStore.Pizza.ChicagoStyle
{
    class ChicagoStyleVeggiePizza : APizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shpinach");
        }
    }
}
