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
             * 簡單工廠封裝了物件建立過程，但他有違背 開放-閉合 的缺點
             * 物件建立過程就是讓使用者不須了解實際物件是如何new的，
             * 而違背 開放-閉合 則是每次新增或修改就必須改動 SimpleFactory內的判斷式，
             * 工廠方法則是維持了簡單工廠的"封裝物件建立過程"，
             * 也克服 開放-閉合 的缺點，
             * 但他本身的缺點就是每每新增一種類別，就必須撰寫相對應的工廠類別，
             * 造成開發量的提高。
             */

        }
    }
}
