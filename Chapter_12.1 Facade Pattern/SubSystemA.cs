using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._1_Facade_Pattern
{
    class SubSystemA
    {
        public void MethodA() 
        {
            Console.WriteLine("Method A");
        }
        public void MethodA2()
        {
            Console.WriteLine("Method A2");
        }
    }
}
