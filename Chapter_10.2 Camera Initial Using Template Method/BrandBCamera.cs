using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._2_Camera_Initial_Using_Template_Method
{
    class BrandBCamera : Camera
    {
        public override void Connect()
        {
            Console.WriteLine("Camera B connect success by Socket.");
        }
        public override void SetParameter()
        {
            Console.WriteLine("Camera B set frame success.");
        }
        public override void StartCapture()
        {
            Console.WriteLine("Camera B start capture success.");
        }
    }
}
