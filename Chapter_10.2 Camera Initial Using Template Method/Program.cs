using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._2_Camera_Initial_Using_Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera a = new BrandACamera();
            Camera b = new BrandBCamera();

            a.InitialCamera();
            b.InitialCamera();


            Console.Read();
        }
    }
}
