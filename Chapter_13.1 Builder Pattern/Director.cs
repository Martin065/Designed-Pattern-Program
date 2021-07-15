using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._1_Builder_Pattern
{
    class Director
    {
        public void Construct(Builder builder) 
        {
            builder.BuildPartB();
            builder.BuildPartA();
        }
    }
}
