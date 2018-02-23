using System;

namespace TemplateMethod {
    class Program {
        static void Main() {
            before1.Tea tea1 = new before1.Tea();
            before1.Coffee coffee1 = new before1.Coffee();
            Console.WriteLine("-------BEFORE1----------------");
            Console.WriteLine("tea...");
            tea1.PrepareRecipe();
            Console.WriteLine("coffee...");
            coffee1.PrepareRecipe();

            before2.CaffeineBeverage tea2 = new before2.Tea();
            before2.CaffeineBeverage coffee2 = new before2.Coffee();
            Console.WriteLine("-------BEFORE2----------------");
            Console.WriteLine("tea...");
            tea2.PrepareRecipe();
            Console.WriteLine("coffee...");
            coffee2.PrepareRecipe();

            after.CaffeineBeverage tea = new after.Tea();
            after.CaffeineBeverage coffee = new after.Coffee();
            Console.WriteLine("-------AFTER1-----------------");
            Console.WriteLine("tea...");
            tea.PrepareRecipe();
            Console.WriteLine("coffee...");
            coffee.PrepareRecipe();

            Console.ReadKey();

        }
    }
}
