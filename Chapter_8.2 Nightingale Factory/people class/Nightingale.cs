using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8._2_Nightingale_Factory
{
    class Nightingale
    {
        public void Sweep() 
        {
            Console.WriteLine("掃地");
        }
        public void Wash() 
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice() 
        {
            Console.WriteLine("買米");
        }
    }
}
