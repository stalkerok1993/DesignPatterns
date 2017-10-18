namespace PizzaStore.Pizza.NYStyle
{
    class NYStylePepperoniPizza : APizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Pepperoni");
        }
    }
}
