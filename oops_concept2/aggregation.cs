using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept2
{
    internal class aggregation
    {

    }
    public class student
    {
        string name;
        string age;
        int rollno;
        int dept_id;
        Marks M; //aggregation ==> has-a relationship
        public student(string name, int age, int rollno, int dept_id, Marks M)
        {
            this.name = name;
            this.age = age.ToString();
            this.rollno = rollno;
            this.dept_id = dept_id;
            this.M= M;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {name}, age: {age}, rollno: {rollno},dept_id: {dept_id} ");
            M.percentageCal();
            Console.WriteLine($"your percentage is: { M.percentage }");
        }

    }
    public class Marks
    {
        public int total_marks;
       public  float percentage;
       

       public  int subjects;
        public Marks(int total_marks,int subjects)
        {
            this.total_marks = total_marks;
            this.subjects = subjects;
        }
        //public float percentage;
        public void percentageCal  ()
        {
           percentage = (total_marks / subjects);
            Console.WriteLine(percentage);
        }
    }

}
