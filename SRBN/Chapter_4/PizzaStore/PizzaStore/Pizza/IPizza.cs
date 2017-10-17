using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizza
{
    interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
