using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_7._1_Chase_Girl_didn_t_Using_Proxy
{
    class Pursuit
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
