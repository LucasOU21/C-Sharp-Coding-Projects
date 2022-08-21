using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            IQuittable quit = new Employee();

            //Call method Quit() from IQuittable
            quit.Quit(employee);

            //Employee list
            employee.FullName = new List<string>() { "John Krik", "Kevin Jay", "Bruce Drew", "Loren Pelino", "Jessica Jones" };
            //employee.ID = new List<int>() { 9965, 9954, 9934, 9959, 9901 };

            foreach (string FullName in employee.FullName)
            {
                employee.SayName(FullName);
             
            }
            Console.ReadLine();
        }
    }
}
