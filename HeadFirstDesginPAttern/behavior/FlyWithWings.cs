using System;
using System.Collections.Generic;
using System.Text;

namespace ch1.behavior
{
    class FlyWithWings : IFlyableBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I' flying write now");
        }
    }
}
