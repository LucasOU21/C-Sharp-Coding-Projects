using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method
{
    class Vmethod
    {
        public static void Math_Calc(int userInput, out int quotient, out int sum)
        {
            sum = userInput + 2;
            quotient = userInput / 2;
        }

        public static void Division(int x)
        {
            {
                int total = x / 2;
                Console.WriteLine(total);
            }

        }


        public static double Math_Calc(double userInput, double quotient)
        {
            return userInput + quotient;
        }

    }
}
