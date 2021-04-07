using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6._3_Avater_Using_Decorator
{
    class Person
    {
        private string name;
        public Person() 
        {
            
        }
        public Person(string name) 
        {
            this.name = name;
        }
        public virtual void show() 
        {
            Console.WriteLine("裝扮的{0}",name);
        }
    }
}
