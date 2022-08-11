using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ClassesandMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter first number:");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No need to enter second number:");
            string d = Console.ReadLine();

            var operatorObject = new Operators();
            int result = operatorObject.Add(e);

            if (d == " ")
            {
                int c = Convert.ToInt32(d);
                Console.WriteLine(operatorObject.Add(c));
            }

            else
            {
                Console.WriteLine(result);

            }

            Console.ReadLine();
        }
    }
}
