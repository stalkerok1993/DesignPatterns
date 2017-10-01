using SimUDuck.Ducks.Behavior;
using System;

namespace SimUDuck.Ducks
{
    abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("Swiming.");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public IFlyBehavior FlyBehavior
        {
            set
            {
                flyBehavior = value;
            }
        }

        public IQuackBehavior QuackBehavior
        {
            set
            {
                quackBehavior = value;
            }
        }
    }
}
