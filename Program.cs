using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, welcome to the Best Bank");
			Console.WriteLine("what would you like to do?");
			Console.WriteLine("1. Login");
			Console.WriteLine("2. Sign Up");
			StartPage.SignUp();
		}
	}
}
	