using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._2_Observer_Pattern_Using_Delegate_and_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            EmployeeWhoWatchNBA employeeWhoWatchNBA = new EmployeeWhoWatchNBA();
            EmployeeWhoWatchStock employeeWhoWatchStock = new EmployeeWhoWatchStock();

            boss.notifyObserver += employeeWhoWatchNBA.response;
            boss.notifyObserver += employeeWhoWatchStock.response;

            boss.Notify("I'm comming.");

            Console.Read();
        }
    }
}
