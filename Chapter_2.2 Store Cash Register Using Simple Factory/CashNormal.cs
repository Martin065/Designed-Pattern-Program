using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._2_Store_Cash_Register_Using_Simple_Factory
{
    class CashNormal: CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
