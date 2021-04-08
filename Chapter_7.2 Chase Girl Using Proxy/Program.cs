using System;

namespace Chapter_7._2_Chase_Girl_Using_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "李嬌嬌";

            Proxy p = new Proxy(mm);   
            p.GiveDolls();
            p.GiveFlowers();
            /*
             * Proxy Pattern目前想不到有什麼應用，
             * 但書中說明了一些應用，例如再代理中附加一些功能，
             * 或者保持真實物件的隱私權等等，
             * 但實際應用目前手邊上的工作還沒有可以產生連結的地方。
             */
        }
    }
}
