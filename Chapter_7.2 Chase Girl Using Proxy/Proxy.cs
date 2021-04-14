using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7._2_Chase_Girl_Using_Proxy
{
    class Proxy:IGiveGift
    {
        Pursuit p ;
        public Proxy(SchoolGirl mm) 
        {
            p = new Pursuit(mm);
        }

        public void GiveDolls() 
        {
            p.GiveDolls();
        }
        public void GiveFlowers() 
        {
            p.GiveFlowers();
        }
    }
}
