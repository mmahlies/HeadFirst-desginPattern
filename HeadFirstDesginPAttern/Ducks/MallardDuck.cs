using ch1.behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace ch1
{
    class MallardDuck: Duck
    {
        public MallardDuck()
        {
            FlyableBehavior = new FlyWithWings();
        }
    }
}
