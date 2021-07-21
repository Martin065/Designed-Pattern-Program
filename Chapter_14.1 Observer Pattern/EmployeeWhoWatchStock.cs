using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._1_Observer_Pattern
{
    class EmployeeWhoWatchStock : Observer
    {
        public void response(String subjectMessage)
        {
            Console.WriteLine("Boss said : " + subjectMessage + " , EmployeeWhoWatchStock close the Stock App.");
        }
    }
}
