using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
          
        {
            Console.WriteLine("Type any number");
            int userValue = Convert.ToInt32(Console.ReadLine());

            var parametersObject = new Parameters();
            int result = parametersObject.Add(userValue, 10);
            int result1 = parametersObject.Subtract(result, 10);
            int result2 = parametersObject.Divide(result1, 2);

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
