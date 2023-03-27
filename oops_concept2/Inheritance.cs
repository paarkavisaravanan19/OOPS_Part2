using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept2
{
    //sealed class can't be inheritance
    public class Inheritance
    {
       public void speed(int speed)
        {
            int MaxSpeed = speed;
            Console.WriteLine(MaxSpeed);
            //Console.WriteLine("maximum speed = 80");
        }
        public void ABS()
        {
            Console.WriteLine("ABS is applied");
        }
            
    }
    public class Benz : Inheritance
    {
       public void Test()
        {
            Console.WriteLine("In benz");
        }
        public void ABS()
        {
            Console.WriteLine("Advanced ABS is applied");
        }
    }
    public class BenzSports : Benz //multilevel inheritance
    {
        public void sportmethod()
        {
            Console.WriteLine("sports");
        }
    }
}
