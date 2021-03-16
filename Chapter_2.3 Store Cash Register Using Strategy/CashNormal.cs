using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._3_Store_Cash_Register_Using_Strategy
{
    class CashNormal: CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
