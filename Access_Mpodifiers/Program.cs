using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Mpodifiers
{
    class Student
    {
        public string name = "Nutan";

        public void print()
        {
            Console.WriteLine("Hello from Student class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            Console.WriteLine("Name: " + student1.name);
            student1.print();
            Console.ReadLine();
        }
    }
}
