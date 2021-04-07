using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6._3_Avater_Using_Decorator
{
    class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component) 
        {
            this.component = component;
        }
        public override void show() 
        {
            if (this.component != null) 
            {
                component.show();
            }       
        }
    }
}
