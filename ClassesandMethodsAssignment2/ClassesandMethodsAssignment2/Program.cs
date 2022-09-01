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
            Operators operators = new Operators();
            Console.WriteLine("Please Enter An Positive Whole Integer:");
            int e = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Enter another Integer or you may leave it blank.");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now the two integers will be added = \n" 
                    + operators.Add(e, d));
            }
            catch (FormatException)
            {
                Console.WriteLine("The only number was typed is" + e);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
