using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._1_Observer_Pattern
{
    class Boss : Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify(string message)
        {
            // 這個範例中，Boss還是必須知道Observer是誰才能通知他們，
            // 萬一你想要被通知的對象沒有實作Observer介面該怎辦呢？ => 透過 Delegate
            foreach (Observer o in observers) 
            {
                o.response(message);
            }
        }
    }
}
