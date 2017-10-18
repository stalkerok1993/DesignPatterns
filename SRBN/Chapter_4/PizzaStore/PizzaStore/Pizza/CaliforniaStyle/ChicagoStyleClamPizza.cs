namespace PizzaStore.Pizza.CaliforniaStyle
{
    class CaliforniaStyleClamPizza : APizza
    {
        public CaliforniaStyleClamPizza()
        {
            Name = "California Style Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Some Sweet Berries");
        }
    }
}
