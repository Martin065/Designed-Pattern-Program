using System;

namespace Chapter_6._1_Avater
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            
            Console.WriteLine("\n第一種裝扮:");

            xc.WearTShirts();
            xc.WearBigTrouser();
            xc.WearSheakers();
            xc.Show();

            Console.WriteLine("\n第二種裝扮:");

            xc.WearSuit();
            xc.WearTie();
            xc.WearLeatherShoes();
            xc.Show();


        }
    }
}
