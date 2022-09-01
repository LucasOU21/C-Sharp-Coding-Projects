using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string playgame = "WonderPlay!";

            Console.WriteLine("Welcome To, {0}. What is your name?", playgame);
            string clientName = Console.ReadLine();
            Console.WriteLine("If you want to go on the ride you need to be at least 150cm");
           
            Console.WriteLine("\n*Measures* {0}", clientName);


            var Addition = new Addition("150");
            var Int = 150;
            if (Int > 140)

            {
                Console.WriteLine(Addition.Speak());
            }
            {
                Console.WriteLine("\n {0} Enjoy the Ride!", clientName);
            }

            Console.ReadLine();
        }
    }
}
