using oops_concept;
namespace oops_concept2
{
    public class MainClass :AccessSpecifier
    {
        static void Main(string[] args)
        {
            //oops_concept2.MainClass specifiers = new oops_concept2.MainClass();
            
            //specifiers.display("paarkavi");
            
            //inheritance
            /*
            var Benz = new BenzSports();
            Benz.speed(40);
            Benz.ABS();
            Benz.Test();
            Benz.sportmethod();*/


            //method overloading
            method1("paarkavi");
            method1("paarkavi", 2);
            Marks marks = new Marks(289, 5);
            student student = new student("cm",20,29,2,marks);

            student.Display();
          myClass obj= new myClass();
            obj.normal(10,20);
            obj.method(30, 40);



            //interface
            child obj1 = new child();
            Iparent obj2 = new child();
            obj1.display("paarkavi");
            obj1.show();
            obj1.calculate(3);
            obj2.result("priya");
            //((Iparent)obj1).result("hello");



        }
        private static void method1(string string1)
        {
            Console.WriteLine("name : "+string1);
        }
        private static void method1(string string1, int id) 
        {
            Console.WriteLine("name : "+ string1 + " id: "+ id);
        }
    }
}