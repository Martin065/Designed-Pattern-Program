using System;

using Chapter_8._1_Factory_Method_Sample.Operation_Class;
using Chapter_8._1_Factory_Method_Sample.Factory_Class;

namespace Chapter_8._1_Factory_Method_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.WriteLine(result);
            /*
             * 目前看不出 Factory Method Pattern 的好處在哪，
             * 因為沒有了 Simple Factory Pattern 把邏輯判斷給包裝起來，
             * 但好像有 Strategy Pattern 的切換性，只要加上條件判斷就可以切換了，
             * 因為已經有 Operation 這個父類別，但具體差異在哪還說不出來
             * [實際上 Strategy Pattern 對於使用者來說會更方便，
             *  因為使用者之需要用context class 去進行宣告(new出底層的物件給context)與操作]
             * 而回過頭看， Simple Factory Pattern 每次新增條件都必須在內部的判斷式中加入新的case判斷條件，
             * 會違反開放閉合原則，所以才會有 Factory Method Pattern 的出現
             * 往後有新增新的類別，只需要做出對應的Factory Class，
             * 並改動 IFactory operFactory = new AddFactory(); 這行的new就可以改變了。
             */
        }
    }
}
