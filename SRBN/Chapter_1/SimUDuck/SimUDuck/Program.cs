using System;
using SimUDuck.Ducks;
using SimUDuck.Ducks.Behavior;
using SimUDuck.Sound;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-> Testing different ducks behaviors.");
            var mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            var redhead = new RedheadDuck();
            redhead.Display();
            redhead.PerformQuack();
            redhead.PerformFly();

            var rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();

            var decoy = new DuckDecoy();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
