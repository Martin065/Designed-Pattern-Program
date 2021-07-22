using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._2_Observer_Pattern_Using_Delegate_and_Event
{
    class Boss
    {
        //public delegate void EventHandler<notifyObserverEventArgs2>(object o , notifyObserverEventArgs args);  // 誤解泛型使用方式
        //public delegate void EventHandler<notifyObserverEventArgs2>();  //eventHandler的泛型不該使用來delegate，泛型是為了省略delegate用的
        //public event EventHandler<notifyObserverEventArgs2> notifyObserver;
        //public event EventHandler notifyObserver;
        public event EventHandler<notifyObserverEventArgs> notifyObserver;
        public void Notify(string message)
        {
            if (notifyObserver != null) // 確認有人註冊了這個Event才去執行Event
            {
                notifyObserverEventArgs args = new notifyObserverEventArgs();
                args.SubjectMessage = "I'm comming.";
                //notifyObserver(this,EventArgs.Empty);
                notifyObserver(this, args);
            }
        }
    }
    class notifyObserverEventArgs : EventArgs
    {
        string subjectMessage;
        public string SubjectMessage
        {
            get { return subjectMessage; }
            set { subjectMessage = value; }
        }
    }
}
