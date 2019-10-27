using System;
using System.Collections.Generic;
using System.Text;

namespace ch1
{
    public abstract class Duck
    {
        public IFlyableBehavior  FlyableBehavior { get; set; }
        


        public void performFly()
        {
            this.FlyableBehavior.Fly();
        }


        // set behavior dynamically
        public void SetBehavior(IFlyableBehavior flyableBehavior)
        {
            this.FlyableBehavior = flyableBehavior;
        }

    }
}
