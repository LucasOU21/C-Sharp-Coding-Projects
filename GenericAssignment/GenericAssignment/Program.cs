using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee<int> employeeID = new Employee<int>();
            Employee<string> employeeNames = new Employee<string>();


            employeeID.info = new List<int>()
            { 
                60,
                12,
                99
            };
            employeeNames.info = new List<string>()
            {
                "Kassie",
                "James",
                "Wendy"
            };
            foreach (int mm in employeeID.info)
            {
                Console.WriteLine(mm);
            }
            foreach (string nn in employeeNames.info)
            {
                Console.WriteLine(nn);
            }
            Console.ReadLine();
        }
    }
}
