using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public Customer() //Constructor
        {

        }

    }
    //parameterized Constructor
    class ParameterConstructor
    {
        public int FirstNumber;
        public int SecondNumber;

        public ParameterConstructor(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer custormer = new Customer();//default Constructor
            custormer.firstName = "Nutan";
            custormer.lastName = "Deshmukh";

            Console.WriteLine("Full Name:" + custormer.firstName + " " + custormer.lastName);
            Console.ReadLine();

            ParameterConstructor p = new ParameterConstructor(10, 20);//parameterized Constructor
            int Result = p.FirstNumber + p.SecondNumber;

            Console.WriteLine("Total:" + Result);
            Console.ReadLine();
        }
    }
}
