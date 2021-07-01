using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._1_TestPaper_Using_Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StudentA Paper:");
            TestPaperOfStudentA studentA = new TestPaperOfStudentA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();

            Console.WriteLine("StudentB Paper:");
            TestPaper studentB = new TestPaperOfStudentB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();

            Console.Read();
        }
    }
}
