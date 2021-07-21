using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._1_Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            EmployeeWhoWatchNBA employeeWhoWatchNBA = new EmployeeWhoWatchNBA();
            EmployeeWhoWatchStock employeeWhoWatchStock = new EmployeeWhoWatchStock();
            boss.Attach(employeeWhoWatchNBA);
            boss.Attach(employeeWhoWatchStock);

            boss.Notify("I'm comming.");

            Console.Read();
        }
    }
}
