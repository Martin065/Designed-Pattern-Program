using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8._1_Factory_Method_Sample.Operation_Class
{
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
