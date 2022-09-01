using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {

                var stud = new Student()
                {
                    StudentName = "George Clooney",
                    DateOfBirth = new DateTime(1961, 05, 06),
                    Height = 1.8m,
                    Weight = 80,
                    Photo = new Byte[1],




                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Data has been Saved.");
            Console.ReadLine();
        }
    }
}
