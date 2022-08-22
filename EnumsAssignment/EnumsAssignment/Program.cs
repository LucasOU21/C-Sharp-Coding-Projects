using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");

            string input = Console.ReadLine();
            try
            {
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);
                Console.WriteLine("It is a " + day + " of the week, Thats Right!");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();
        }
        public enum DaysOfWeek
        {
         
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
