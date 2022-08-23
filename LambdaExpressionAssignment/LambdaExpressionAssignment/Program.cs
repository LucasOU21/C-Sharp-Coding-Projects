using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            List<string> Firstnames = new List<string>()
{
            "Joe", "Cam", "Duke", "Joe", "Rebecca", "Daisy", "Josh", "Kai", "John", "Sophia"
};

            List<string> Lastnames = new List<string>()
{
             "Kimmer", "Jimmy", "Homer", "Smith", "Hudson", "Summer", "Scarlor", "Daniel", "Penny", "Justin"
};

            List<int> IDs = new List<int>()
{
             102, 156, 4, 130, 120, 3, 106, 126, 1, 101
};

            List<int> indexes = new List<int>()
{
             0, 1, 2, 3, 4, 5, 6, 7, 8, 9
};

            foreach (int index in indexes)
            {
                Employee Employeeobj = new Employee();
                Employeeobj.firstname = Firstnames[index];
                Employeeobj.lastname = Lastnames[index];
                Employeeobj.ID = IDs[index];
                Employees.Add(Employeeobj);

            }

            foreach (var empl in Employees)

            {

                if (empl.firstname == "Joe")//Foreach loop for the list that starts with the name "Joe"
                {

                    Console.WriteLine(empl.firstname + " " + empl.lastname + " " + empl.ID);

                }

            }

            Console.WriteLine();

            var empl2 = Employees.FindAll(m => m.firstname == "Joe"); //lambda expression for the action performed above
            foreach (var emp2 in empl2)
            {
                Console.WriteLine(emp2.firstname + " " + emp2.lastname + " " + emp2.ID);
            }

            Console.WriteLine();

            var id = Employees.FindAll(d => d.ID > 5); //lambda expression for making a list of all employees with an Id number greater than 5.
            foreach (var idm in id)
            {

                Console.WriteLine(idm.firstname + " " + idm.lastname + " " + idm.ID);


            }
            Console.WriteLine();

            foreach (Employee Employee in Employees)
            {

                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }

            Console.ReadLine();
        }
    }
}
