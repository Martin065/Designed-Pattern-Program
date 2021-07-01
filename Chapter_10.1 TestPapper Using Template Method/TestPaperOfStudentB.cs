using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._1_TestPaper_Using_Template_Method
{
    class TestPaperOfStudentB:TestPaper
    {
        protected override string Answer1()
        {
            return "d";
        }
        protected override string Answer2()
        {
            return "c";
        }
    }
}
