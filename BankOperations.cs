using System;
using System.Collections;
using System.Collections.Generic;

namespace Banking_App
{
    public class BankOperations
	{
		public Account LandingPage()
		{
			Console.WriteLine("Hello, welcome to the Best Bank");
			Console.WriteLine("what would you like to do?");
			Console.WriteLine("1. Login");
			Console.WriteLine("2. Sign Up");
			string user_input = Console.ReadLine();
			if(user_input.Equals("1"))
			{
				Console.WriteLine("Login \n \n");

				Console.Write("Account Number: ");
				string accountNumber = Console.ReadLine();

				Console.Write("Password: ");
				string password = Console.ReadLine();

				var loginDetails = AccessPage.Login(new BankAccounts(), accountNumber, password);

				if (loginDetails != null)
				{
					return loginDetails;
				}
				else
				{
					Console.WriteLine("This account doesn't exist \n \n");
					BankOperations temp = new BankOperations();
					temp.LandingPage();
					return null;
				}
			}
			else
			{
				var signupDetails = AccessPage.SignUp();
				return signupDetails;
			}
		}
	}
}