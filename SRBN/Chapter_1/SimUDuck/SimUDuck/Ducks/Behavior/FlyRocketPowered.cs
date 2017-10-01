using System;

namespace SimUDuck.Ducks.Behavior
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with a rocket!");
        }
    }
}
