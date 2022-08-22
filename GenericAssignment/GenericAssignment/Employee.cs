using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericAssignment
{
	public class Employee<T>
	{
		public int employeeID { get; set; }
		public string employeeNames { get; set; }

		public List<T> info;
	}
}
