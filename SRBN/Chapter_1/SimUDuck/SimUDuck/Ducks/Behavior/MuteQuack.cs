using System;

namespace SimUDuck.Ducks.Behavior
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<silent>");
        }
    }
}
