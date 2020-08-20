using System;
using System.Collections.Generic;
using System.Dynamic;
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
			string user_input = Console.ReadLine();
			switch (user_input)
			{
				case "1":
					StartPage.Login();
					break;
				case "2":
					StartPage.SignUp();
					break;
			}
		}
	}
}
	
