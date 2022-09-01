using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vclass;

namespace ClassesandMethodsAssignment3
{
    class Program
    {

        static void Main(string[] args)
        {

            Class1 sum = new Class1();

            Console.Write("\n\nMethod to calculate the sum of two numbers :\n");

            Console.Write("Type any number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number: ");

            int n2 = Convert.ToInt32(Console.ReadLine());
            sum.Sum(n1, n2);
            Console.WriteLine("Second number is = " + n2);
            Console.ReadLine();
        }

        
    }
}