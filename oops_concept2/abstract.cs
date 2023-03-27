using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept2
{
    // abstract can have abstract class and non-abstract classes 
    abstract public class abstratc //abstraction 
    {

        abstract public void method(int a, int b);
        public void normal(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        
       
    }
    public  class myClass: abstratc
    {
        override public void  method(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }
}
