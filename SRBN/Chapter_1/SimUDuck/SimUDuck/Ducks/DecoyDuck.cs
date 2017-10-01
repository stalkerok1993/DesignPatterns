using SimUDuck.Ducks.Behavior;
using System;

namespace SimUDuck.Ducks
{
    class DuckDecoy : Duck
    {
        public DuckDecoy()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a decoy-duck.");
        }
    }
}
