using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._2_Resume_Using_Prototype__Deep_Copy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("BigBird");
            a.SetPersonalInfo("Male", "29");
            a.SetWorkExperience("1998-2000", "XX Company");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY Company");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("Male", "24");
            c.SetWorkExperience("1998-2003", "ZZ Company");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
            /* 
             * 套用與Chapter_9.1相同的用戶端程式碼，可以觀察到結果已經不同，各自的修改並不會影響到其他人的資訊。
             */
        }
    }
}
