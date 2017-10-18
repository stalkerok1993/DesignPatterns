namespace PizzaStore.Pizza.ChicagoStyle
{
    class ChicagoStylePepperoniPizza : APizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Pepperoni");
        }
    }
}
