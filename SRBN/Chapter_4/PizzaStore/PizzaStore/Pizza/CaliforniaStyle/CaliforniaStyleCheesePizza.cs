namespace PizzaStore.Pizza.CaliforniaStyle
{
    class CaliforniaStyleCheesePizza : APizza
    {
        public CaliforniaStyleCheesePizza()
        {
            Name = "California Style Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Great Amount of Homemade Goat Cheese");
        }
    }
}
