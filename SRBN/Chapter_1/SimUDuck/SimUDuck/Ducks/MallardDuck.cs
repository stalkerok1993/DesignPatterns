using SimUDuck.Ducks.Behavior;
using System;

namespace SimUDuck.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard.");
        }
    }
}
