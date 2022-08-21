using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
		public class Person
		{
        public List<string> FullName { get; set; }

        public
            void SayName(string x = null)
        {
            Console.WriteLine("Employee info: " + x);

        }
	}
}
