using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._4_Store_Cash_Register_Using_Strategy_and_Simple_Factory
{
    class CashRebate :CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate) 
        {
            this.moneyRebate = Convert.ToDouble(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
