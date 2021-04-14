using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8._1_Factory_Method_Sample.Operation_Class
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除數不得為零");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
