using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._1_TestPaper_Using_Template_Method
{
    class TestPaper
    {
        // Question1
        public void TestQuestion1() 
        {
            Console.WriteLine("Question1 : answer is [a] or [b] or [c] or [d]");
            Console.WriteLine("Answer is " + Answer1());
        }
        protected virtual string Answer1() 
        {
            return "";
        }
        public void TestQuestion2()
        {
            Console.WriteLine("Question2 : answer is [a] or [b] or [c] or [d]");
            Console.WriteLine("Answer is " + Answer2());
        }
        protected virtual string Answer2()
        {
            return "";
        }
    }
}
