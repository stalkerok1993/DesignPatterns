using System;

namespace SimpleSingletone
{
    class Program
    {
        static void Main(string[] args)
        {
            // There are a good article about Singletone in C# in Depth book: http://csharpindepth.com/articles/general/singleton.aspx

            Singletone singletone = Singletone.Instance;

            if (singletone == Singletone.Instance) {
                Console.WriteLine(singletone.Name);
            }
            else {
                Console.WriteLine("Wrong Singletone inplementation!");
            }

            ChocolateBoiler chocolateBoilerSingletone = ChocolateBoiler.Instance;
            if (chocolateBoilerSingletone == ChocolateBoiler.Instance)
            {
                Console.WriteLine("Boiler is OK");
            }
            else
            {
                Console.WriteLine("Ups, you're dead...");
            }
        }
    }
}
