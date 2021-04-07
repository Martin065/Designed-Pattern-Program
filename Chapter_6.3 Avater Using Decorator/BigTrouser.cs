using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6._3_Avater_Using_Decorator
{
    class BigTrouser : Finery
    {
        public override void show()
        {
            Console.WriteLine("垮褲");
            base.show();
        }
    }
}
