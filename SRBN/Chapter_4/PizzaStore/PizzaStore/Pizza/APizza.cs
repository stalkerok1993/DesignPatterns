using System;
using System.Collections.Generic;

namespace PizzaStore.Pizza
{
    abstract class APizza
    {
        public string Name { get; protected set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings { get; set; } = new List<string>();
        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
