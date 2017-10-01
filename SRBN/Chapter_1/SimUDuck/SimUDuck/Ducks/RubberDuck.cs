using SimUDuck.Ducks.Behavior;
using System;

namespace SimUDuck.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Look line a rubberduck.");
        }
    }
}
