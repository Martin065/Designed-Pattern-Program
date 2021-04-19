using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8._2_Nightingale_Factory.factory
{
    class VolunteerFactory:IFactory
    {
        public Nightingale CreateNightingale() 
        {
            return new Volunteer();
        }
    }
}
