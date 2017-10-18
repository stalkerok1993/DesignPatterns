namespace PizzaStore.Pizza.CaliforniaStyle
{
    class CaliforniaStylePepperoniPizza : APizza
    {
        public CaliforniaStylePepperoniPizza()
        {
            Name = "California Style Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Roast Meat");
        }
    }
}
