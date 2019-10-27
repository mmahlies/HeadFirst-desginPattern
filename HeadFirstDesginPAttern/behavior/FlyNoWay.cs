using System;
using System.Collections.Generic;
using System.Text;

namespace ch1.behavior
{
    public class FlyNoWay : IFlyableBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cant fly"); 
        }
    }
}
