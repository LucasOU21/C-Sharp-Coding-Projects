﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractproject
{
	public class Employee : Person
	{
		public void SayName()
		{
			Console.WriteLine(firstName + "" + lastName);
		}
	}
}