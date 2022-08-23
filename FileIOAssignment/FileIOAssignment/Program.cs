using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Enter a number.");

            int userValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(userValue)

            string fpath = @"C:\Users\lucas\All my code\C-Sharp-Coding-Projects/log.txt";
            using (StreamWriter file = new StreamWriter(fpath, true))
            {
                file.WriteLine(userValue);
            }

            Console.ReadLine();
        }
    }
}
