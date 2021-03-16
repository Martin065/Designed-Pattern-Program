using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._3_Store_Cash_Register_Using_Strategy
{
    class CashContext
    {
        CashSuper cs = null;
        public CashContext(CashSuper cashSuper)
        {
            this.cs = cashSuper;
        }
        public double getResult(double money) 
        {
            double result = 0;
            result = this.cs.acceptCash(money);
            return result;
        }
    }
}
