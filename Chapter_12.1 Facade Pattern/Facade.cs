using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._1_Facade_Pattern
{
    class Facade
    {
        SubSystemA A;
        SubSystemB B;
        SubSystemC C;
        SubSystemD D;

        public Facade() 
        {
            A = new SubSystemA();
            B = new SubSystemB();
            C = new SubSystemC();
            D = new SubSystemD();
        }
        public void MethodGroupOne() 
        {
            Console.WriteLine("Function Group One ---");
            A.MethodA();
            B.MethodB2();
            A.MethodA2();
        }
        public void MethodGroupTwo()
        {
            Console.WriteLine("Function Group Two ---");
            C.MethodC2();
            D.MethodD();
        }
    }
}
