using ch1.behavior;
using System;

namespace ch1
{
   class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            // default behaviour
            mallardDuck.performFly();

            // pass new behaviour to the duck so that it can behave diffrently
            mallardDuck.SetBehavior(new FlyNoWay());
        }
    }

    
}
