using SimUDuck.Ducks.Behavior;
using System;

namespace SimUDuck.Ducks
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a redhead.");
        }
    }
}
