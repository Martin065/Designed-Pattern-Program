using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8._2_Nightingale_Factory
{
    class SimpleFactory
    {
        public static Nightingale CreateNightale(string type) 
        {
            Nightingale result = null;
            switch (type) 
            {
                case "學南丁格爾的大學生":
                    result = new Undergraduate();
                    break;
                case "社區義工":
                    result = new Volunteer();
                    break;
                default:
                    result = new Volunteer();
                    break;
            }
            return result;
        }
    }
}
