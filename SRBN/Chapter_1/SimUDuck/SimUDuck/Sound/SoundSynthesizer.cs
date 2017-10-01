using SimUDuck.Ducks.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Sound
{
    class SoundSynthesizer
    {
        private IQuackBehavior quackBehavior;

        public SoundSynthesizer()
        {
            quackBehavior = new Quack();
        }

        public void DuckSound()
        {
            quackBehavior.Quack();
        }
    }
}
