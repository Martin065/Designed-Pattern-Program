using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7._2_Chase_Girl_Using_Proxy
{
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm) 
        {
            this.mm = mm;
        }
        public void GiveDolls() 
        {
            Console.WriteLine(mm.Name + "送你洋娃娃");
        }
        public void GiveFlowers() 
        {
            Console.WriteLine(mm.Name + "送你鮮花");
        }
    }
}
