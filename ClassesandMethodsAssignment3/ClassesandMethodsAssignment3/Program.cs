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

            Class1 class1 = new Class1();

            Console.Write("\n\nMethod to calculate the sum of two numbers :\n");

            Console.Write("Type any number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int z = Sum(n1, 100);
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", z);
            Console.WriteLine("Second number is = " + n2);
            Console.ReadLine();
        }

        private static int Sum(int n1, int v)
        {
            throw new NotImplementedException();
        }
    }
}