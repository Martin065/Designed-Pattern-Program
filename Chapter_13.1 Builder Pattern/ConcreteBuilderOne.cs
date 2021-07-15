using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._1_Builder_Pattern
{
    class ConcreteBuilderOne : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("Compoment hand");
        }
        public override void BuildPartB()
        {
            product.Add("Compoment arm");
        }
        public override Product GetResult()
        {
            return product;
        }
    }
}
