using System;

namespace SimUDuck.Ducks.Behavior
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
