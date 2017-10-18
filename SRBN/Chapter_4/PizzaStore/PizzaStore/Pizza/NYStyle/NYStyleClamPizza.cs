namespace PizzaStore.Pizza.NYStyle
{
    class NYStyleClamPizza : APizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Clam");
        }
    }
}
