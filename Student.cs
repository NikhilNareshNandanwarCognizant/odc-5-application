using System;
using System.Collections.Generic;
using System.Text;

namespace ODC5Application
{
	internal class Student
	{
		public string name;
		public int age;
		public int id;

		public void PrintData()
		{
			Console.WriteLine($"Name: {name}");
		}
	}
}
