using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6._2_Avater_Using_Open_Close
{
    class Person
    {
        private string name;
        public Person(string name) 
        {
            this.name = name;
        }
        public void show() 
        {
            Console.WriteLine("裝扮的{0}",name);
        }
    }
}
