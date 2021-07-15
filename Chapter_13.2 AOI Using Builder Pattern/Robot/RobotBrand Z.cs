using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class RobotBrand_Z : Robot
    {
        public override void initial()
        {
            Console.WriteLine("RobotBrand_Z Initial Success.");
        }

        public override void showCompomentInfo()
        {
            Console.WriteLine("The Robot is RobotBrand_Z");
        }
    }
}
