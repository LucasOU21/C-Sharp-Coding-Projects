using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods_Assignment_1
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            var OperationObject = new MathOperations();

            int result = OperationObject.Add(userValue, 8);
            int result1 = OperationObject.Subtract(result, 5);
            int result2 = OperationObject.Divide(result1, 6);
            double result3 = OperationObject.Decimal(result2, 1.5);


            Console.WriteLine("If you add " + userValue + " to 8 the answer is:" + result);
            Console.WriteLine("Subtracted 5 from " + result + " is: " + result1);
            Console.WriteLine("Divided by 6 from " + result1 + " is: " + result2);
            Console.WriteLine("Multiply 2.5 to " + result2 + " is " + result3);


            Console.WriteLine("Please enter a decimal numbers:");
            var userDValue = Convert.ToDouble(Console.ReadLine());

            double r = OperationObject.Decimal(userDValue, 2.5);

            Console.WriteLine(userDValue + " multiply to 2.5 is " + r);

            Console.ReadLine();
        }
    }
}
