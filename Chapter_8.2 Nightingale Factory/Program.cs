using System;
using Chapter_8._2_Nightingale_Factory.factory;


namespace Chapter_8._2_Nightingale_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Version 1 : 學南丁格爾的大學生
             * 
             * Nightingale hugon = new Undergraduate();
             * hugon.BuyRice();
             * hugon.Sweep();
             * hugon.Wash();
             */

            /* // Version 2 : 簡單工廠模式
             * 
             * Nightingale studentA = SimpleFactory.CreateNightale("學南丁格爾的大學生");    
             * studentA.BuyRice();
             * Nightingale studentB = SimpleFactory.CreateNightale("學南丁格爾的大學生");
             * studentB.Sweep();
             * Nightingale studentC = SimpleFactory.CreateNightale("學南丁格爾的大學生");
             * studentC.Wash();
             */
            /*
             * 如果大學生要換成義工，以這個方式就要改三個地方。
             * 如果工廠內又要多一個種類例如社會人士或退休人員，
             * 就需要再進入工廠內的switch進行case的增加修改，
             * 違背 開放-閉合 原則。
             */

            // Version 3 : 工廠方法模式
            IFactory factory = new UndergraduateFactory();   // 如果要換成義工，改這邊就可以了。
            Nightingale people = factory.CreateNightingale();

            people.BuyRice();
            people.Sweep();
            people.Wash();
            /*
             * Simple Factory 封裝了物件建立過程，但他有違背 開放-閉合 的缺點
             * 物件建立過程就是讓使用者不須了解實際物件是如何new的，
             * 而違背 開放-閉合 的地方則是每次新增或修改就必須改動 Simple Factory 內的判斷式[switch case]，
             * Factory Method 則是維持了 Simple Factory 的"封裝物件建立過程"[使用者看不到底層物件被new，因為包裝在Factory Class中]，
             * 也克服 開放-閉合 的缺點[新增新的Class的時候不須改動switch case內的判斷式，直接新增新類別與對應的工廠類別就好]，
             * 但他本身的缺點就是每每新增一種類別，就必須撰寫相對應的工廠類別，
             * 造成開發量的提高。
             * 如果這樣的寫法又再包裝一層 Simple Factory 會怎樣呢? 
             * => 其實就會被綁死，沒有了新增的彈性，新增新類別的話會違背 開放-閉合 [因為要去修改switch case]。
             * 看起來 Simple Factory 使用上必須是既有的類別中，不太會新增新的類別時使用。
             * Factory Method 則像是在開發階段，不斷有新的類別會出現被使用，保持了擴充的彈性。
             */
            /*
             * 書中舉的例子是說，如果要換一個人去做這些事情，只需要改動一個地方就好，
             * 實務上會需要這樣的架構的情境有那些呢?
             * 情境 : 相同類型的多個物件去做不同的事情
             * 可能像是相機，一台檢測設備可能需要三台相機，
             * 今天是使用A廠牌的三台相機進行測試，
             * 明天又要換B廠牌的相機進行測試，
             * 這時候使用這種架構就會很容易進行切換，
             * 同時主體架構不變，因此維護與新增刪除都非常便利，
             * 對於團隊分工來說，只要 Nightingale 這層介面定義的完善，
             * 就可以讓寫主架構的人不必顧慮負責相機類別人的他怎麼寫，
             * 只要能滿足 Nightingale 介面所定義的function即可。
             */

        }
    }
}
