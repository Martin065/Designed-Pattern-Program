using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._1_Builder_Pattern
{
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part) 
        {
            parts.Add(part);
        }
        public void Show() 
        {
            Console.WriteLine("\n Product create ---");
            foreach (string part in parts) 
            {
                Console.WriteLine(part);
            }
        }
    }
}
