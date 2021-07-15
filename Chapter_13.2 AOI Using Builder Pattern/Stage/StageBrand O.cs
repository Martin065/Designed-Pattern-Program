using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class StageBrand_O : Stage
    {
        public override void initial()
        {
            Console.WriteLine("StageBrand_O Initial Success.");
        }

        public override void showCompomentInfo()
        {
            Console.WriteLine("The Stage is StageBrand_O");
        }
    }
}
