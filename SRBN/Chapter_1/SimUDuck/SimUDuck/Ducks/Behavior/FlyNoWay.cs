using System;

namespace SimUDuck.Ducks.Behavior
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}
