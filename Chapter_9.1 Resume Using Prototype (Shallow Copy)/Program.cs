using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._1_Resume_Using_Prototype__Shallow_Copy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("BigBird");
            a.SetPersonalInfo("Male" , "29");
            a.SetWorkExperience("1998-2000" , "XX Company");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006" , "YY Company");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("Male","24");
            c.SetWorkExperience("1998-2003" , "ZZ Company");

            a.Display();
            b.Display();
            c.Display();
            
            Console.Read();
        }
    }
}
