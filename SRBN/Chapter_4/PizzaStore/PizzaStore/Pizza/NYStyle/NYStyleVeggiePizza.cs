namespace PizzaStore.Pizza.NYStyle
{
    class NYStyleVeggiePizza : APizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Argula");
        }
    }
}
