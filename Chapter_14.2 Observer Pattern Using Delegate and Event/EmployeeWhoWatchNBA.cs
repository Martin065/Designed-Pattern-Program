using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._2_Observer_Pattern_Using_Delegate_and_Event
{
    class EmployeeWhoWatchNBA 
    {
        public void response(Object o, notifyObserverEventArgs subjectMessage)
        {
            notifyObserverEventArgs args = (notifyObserverEventArgs)subjectMessage;
            Console.WriteLine("Boss said : " + args.SubjectMessage + " , EmployeeWhoWatchNBA close the NBA Vedio.");
        }
    }
}
