using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept2
{
    public interface Iparent
    {
        public void show();
        public void display(string msg);
       
        public void calculate(int age);
        public void result(string name)
        {
            Console.WriteLine(name);
        }
       
    }
    public class child: Iparent
    {
        public void show()
        {
            Console.WriteLine("inside child class");
        }
        public void calculate(int age)
        {

            Console.WriteLine(age);
        }
        public void display(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
