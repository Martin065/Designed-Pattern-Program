using System;

namespace Chapter_6._3_Avater_Using_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("第一種裝扮 : ");

            TShirts ts = new TShirts();
            BigTrouser bt = new BigTrouser();

            ts.Decorate(xc);
            bt.Decorate(ts);

            bt.show();

            /*
             * 使用完這個模式可以聯想到，之前前輩使用command pattern來應付不同的使用者需求，
             * 因此進來什麼command，就執行該command所屬類別的動作，這樣的前提是這些command類別都要定義出相同的function名稱，
             * 而decorate pattern似乎也要定義出相同的function名稱，只是他可以串接不同的程式碼，
             * 那麼這兩個模式的差異在哪呢?
             * 仔細思考一下，前輩使用的command pattern是為了包容不同類別的物件去執行不同的function內容，
             * 算是平行式的區分不同的類別，並統一在一個程式碼位置去執行，
             * 而decorate pattern是直列式的串接不同的function內容，比較像是有組合function內容的彈性，
             * 應該可以套用到前輩的command pattern之上，讓不同類別的物件有一個執行順序。
             * 
             * 兩者的用途目前還有點混亂，
             * 總結來說：
             * command pattern 可以簡化啟動不同類別物件的啟動位置，濃縮成一個，也就是說不管傳進來的物件是誰，他都可以啟動。
             * decorate pattern 可以串接不同功能到同一個物件上，再由最後一個物件去啟動。
             * 
             * 應用端來說：
             * 先透過decorate pattern把需要的功能串接起來，統一丟到command pattern的啟動位置去啟動。
             * 
             * 又或許說，友崧用的只是多型的概念，還不是真正的command pattern。
             */
        }
    }
}
