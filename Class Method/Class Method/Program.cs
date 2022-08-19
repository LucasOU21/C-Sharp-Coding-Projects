using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vmethod obj = new Vmethod();
            DoubleC obj = new DoubleC();

            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int q, s, a = userInput;

            Vmethod.Math_Calc(a, out q, out s);
            double m = Vmethod.Math_Calc(a, q);

            Console.WriteLine("x : 2 = y");
            Console.WriteLine("Type an positive whole number");
            int userValue = Convert.ToInt32(Console.ReadLine());
            Vmethod.Division(userValue / 2);

            Console.WriteLine("12 / 8:");
            int y = 12;
            int z = 8;
            Vmethod.Division(y / z);


            Console.WriteLine("The quotient after dividing {0} by {1}: {2} ,  adding  2 : {3}", a, 2, q, s);
            Console.WriteLine("The sum of quotient after adding " + a + " is " + m);




            Console.ReadLine();
        }
    }
}
