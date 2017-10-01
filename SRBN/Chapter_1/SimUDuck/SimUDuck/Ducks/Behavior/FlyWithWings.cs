using System;

namespace SimUDuck.Ducks.Behavior
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
