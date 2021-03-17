using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._4_Store_Cash_Register_Using_Strategy_and_Simple_Factory
{
    class CashContext
    {
        CashSuper cs = null;
        public CashContext(string strategy)
        {                        
            switch (strategy)
            {
                case "無折扣":
                    cs = new CashNormal();
                    break;
                case "打七折":
                    cs = new CashRebate("0.7");
                    break;
                case "滿五百折一百":
                    cs = new CashReturn("500", "100");
                    break;
                case "滿五百折兩百":
                    cs = new CashReturn("500", "200");
                    break;
                default:
                    cs = new CashNormal();
                    break;
            }
        }
        public double getResult(double money) 
        {
            double result = 0;
            result = this.cs.acceptCash(money);
            return result;
        }
    }
}
