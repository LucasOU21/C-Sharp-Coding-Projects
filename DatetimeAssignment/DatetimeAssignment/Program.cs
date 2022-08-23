using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to add more hours to the current time:");

            int userIn = Convert.ToInt32(Console.ReadLine());

            DateTime date = DateTime.Now;

            Console.WriteLine("Current time: " + DateTime.Now);
            DateTime dt1 = date.AddHours(userIn);

            Console.WriteLine("After adding your number the date and time is: " + dt1);


            Console.ReadLine();
        }
    }
}
