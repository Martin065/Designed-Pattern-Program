using System;
using System.Collections.Generic;
using System.Text;

using Chapter_8._1_Factory_Method_Sample.Operation_Class;

namespace Chapter_8._1_Factory_Method_Sample.Factory_Class
{
    class MulFactory : IFactory
    {
        public Operation CreateOperation() 
        {
            return new OperationMul();
        }
    }
}
