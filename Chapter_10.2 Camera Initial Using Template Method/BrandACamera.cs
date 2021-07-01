using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._2_Camera_Initial_Using_Template_Method
{
    class BrandACamera : Camera
    {
        public override void Connect()
        {
            Console.WriteLine("Camera A connect success by serial port." );
        }
        public override void SetParameter()
        {
            Console.WriteLine("Camera A set white balance success.");
        }
        public override void StartCapture()
        {
            Console.WriteLine("Camera A start capture success.");
        }
    }
}
