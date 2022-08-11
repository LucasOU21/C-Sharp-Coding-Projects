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

            Console.WriteLine("x : 2 = y");
            Console.WriteLine("Type an positive whole number");
            int userValue = Convert.ToInt32(Console.ReadLine());
            Vmethod.Division(userValue / 2);

            Console.WriteLine("12 / 8:");
            int y = 12;
            int z = 8;
            Vmethod.Division(y / z);


            Console.ReadLine();
        }
    }
}
