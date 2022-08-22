using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ID10 = new Employee();

            ID10.FirstName = "Kim";
            ID10.LastName = "Janne";
            ID10.ID = 72943732;

            Employee ID20 = new Employee();

            ID20.FirstName = "Poppy";
            ID20.LastName = "Lemon";
            ID20.ID = 325525252;

            Employee ID30 = new Employee();

            ID30.FirstName = "Ben";
            ID30.LastName = "Lozeno";
            ID30.ID = 54747454;

            Employee ID40 = new Employee();

            ID40.FirstName = "Paxton";
            ID40.LastName = "Bron";
            ID40.ID = 54747454;

            if (ID10 == ID20) 
                Console.WriteLine("IDs are a match ");
            else
                Console.WriteLine("Different IDs");

            if (ID30 == ID40)
                Console.WriteLine("IDs are a match ");
            else
                Console.WriteLine("Different IDs");

            Console.ReadLine();
        }
    }
}
