using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._2_Store_Cash_Register_Using_Simple_Factory
{
    class CashFactory
    {
        public static CashSuper createCashAcept(string discountType) 
        {
            CashSuper cashS = null;
            switch (discountType) 
            {
                case "無折扣":
                    cashS = new CashNormal();
                    break;
                case "打七折":
                    cashS = new CashRebate("0.7");
                    break;
                case "滿五百折一百":
                    cashS = new CashReturn("500" , "100");   // 如果要工廠內的類別參數都彈性，那麼在這個function介面就得有更多參數
                    break;
                case "滿五百折兩百":
                    cashS = new CashReturn("500", "200");
                    break;
                default:
                    cashS = new CashNormal();
                    break;
            }
            return cashS;
        }
    }
}
