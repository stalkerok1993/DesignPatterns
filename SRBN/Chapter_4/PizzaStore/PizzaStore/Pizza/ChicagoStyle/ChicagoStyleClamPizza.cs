namespace PizzaStore.Pizza.ChicagoStyle
{
    class ChicagoStyleClamPizza : APizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Different Clams");
        }
    }
}
