using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class OpticalBrand_B : OpticalSensor
    {
        public override void initial()
        {
            Console.WriteLine("OpticalBrand_B Initial Success.");
        }

        public override void showCompomentInfo()
        {
            Console.WriteLine("The Optical Sensor is OpticalBrand_B");
        }
    }
}
