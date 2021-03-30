using System;

namespace Chapter_6._2_Avater_Using_Open_Close
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("小菜");
            Finery t = new TShirts();
            Finery b = new BigTrouser();
           
            // 這樣寫雖然把人和衣服類別分開了，但每用一個服裝就要建立一個不同的物件並呼叫function
            t.show();
            b.show();
            p.show();
        }
    }
}
