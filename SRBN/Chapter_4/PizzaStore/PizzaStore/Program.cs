using PizzaStore.Factory;
using PizzaStore.Pizza;
using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            APizzaStore nyStore = new NYPizzaStore();
            APizzaStore chicagoStore = new ChicagoPizzaStore();

            APizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
