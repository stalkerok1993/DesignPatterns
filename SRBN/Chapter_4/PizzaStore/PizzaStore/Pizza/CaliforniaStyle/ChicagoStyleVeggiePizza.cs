namespace PizzaStore.Pizza.CaliforniaStyle
{
    class CaliforniaStyleVeggiePizza : APizza
    {
        public CaliforniaStyleVeggiePizza()
        {
            Name = "California Style Veggie Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Mango");
        }
    }
}
