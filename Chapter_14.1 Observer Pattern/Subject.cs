using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._1_Observer_Pattern
{
    interface Subject
    {        
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify(string message);
        
    }
}
