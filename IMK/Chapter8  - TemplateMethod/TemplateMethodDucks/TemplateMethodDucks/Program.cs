using System;

namespace TemplateMethodDucks {
    class Program {
        static void Main() {
            Duck[] ducks = {
                new Duck("Dark3", 3),
                new Duck("Dark1", 1),
                new Duck("Duck4", 4),
                new Duck("Duck2", 2)
            };

            Console.WriteLine("DUCKS WITHOUT SORTING");
            Display(ducks);

            Array.Sort(ducks);
            Console.WriteLine("SORTED DUCKS");
            Display(ducks);

            Console.ReadKey();
        }

        private static void Display(Duck[] ducks) {
            foreach (var duck in ducks) {
                Console.WriteLine(duck.Name, "-", duck.Weight);
            }
        }
    }
}
