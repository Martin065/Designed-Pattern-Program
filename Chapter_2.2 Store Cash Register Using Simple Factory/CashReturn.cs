using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2._2_Store_Cash_Register_Using_Simple_Factory
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition , string moneyReturn) 
        {
            this.moneyCondition = Convert.ToDouble( moneyCondition);
            this.moneyReturn = Convert.ToDouble( moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double moneyResult = money;
            if (money >= moneyCondition) 
            {
                moneyResult = money - (Math.Floor(money / moneyCondition) * moneyReturn);
            }            
            return moneyResult;
        }
    }
}
