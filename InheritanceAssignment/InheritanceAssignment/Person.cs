using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
    {  

public class Person
{
    

        string FirstName = "Jammie";
        string LastName = "Cruise";

    public virtual void SayName()
    {
        Console.WriteLine("FirstName: {0}", FirstName);
        Console.WriteLine("LastName: {0}", LastName);
        Console.ReadLine();
      }

    }
}
