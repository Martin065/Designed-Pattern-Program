using System;

namespace Chapter_7._1_Chase_Girl_didn_t_Using_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "李嬌嬌";

            Pursuit p = new Pursuit(mm);    // 這樣代表p直接認識mm，並且是p直接送禮物給mm了
            p.GiveDolls();
            p.GiveFlowers();
        }
    }
}
