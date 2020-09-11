using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Banking_App
{
	class Program
	{
		static void Main(string[] args)
		{
			BankOperations bankOperations = new BankOperations();
			var user = bankOperations.LandingPage();

			if (user.AccountType.Equals("Savings"))
			{
				SavingsOperations(user);
			}
			else
			{
				CurrentOperations(user);
			}
		}

		private static void CurrentOperations(Account user)
		{
			Current current = new Current();

			Console.WriteLine("Welcome " + user.Name);
			Console.WriteLine("What would you like to do? \n");

			Console.WriteLine("1. Make a Deposit");

			Console.WriteLine("2. Withdraw Money");

			Console.WriteLine("3. Check Account Balance");

			string userInput = Console.ReadLine();
			if (userInput.Equals("1"))
			{
				Console.WriteLine("How much you wan deposit?");
				int amount = Convert.ToInt32(Console.ReadLine());

				current.Deposit(user, amount);
			}
			else if (userInput.Equals("2"))
			{
				Console.WriteLine("How much you wan commot?");
				int amount = Convert.ToInt32(Console.ReadLine());

				current.Withdraw(user, amount);
			}
			else if (userInput.Equals("3"))
			{
				current.GetAccountBalance(user);
			}
		}

		private static void SavingsOperations(Account user)
		{
			Savings savings = new Savings();

			Console.WriteLine("Welcome " + user.Name);
			Console.WriteLine("What would you like to do? \n");

			Console.WriteLine("1. Make a Deposit");

			Console.WriteLine("2. Withdraw Money");

			Console.WriteLine("3. Check Account Balance");

			string userInput = Console.ReadLine();
			if (userInput.Equals("1"))
			{
				Console.WriteLine("How much you wan deposit?");
				int amount = Convert.ToInt32(Console.ReadLine());

				savings.Deposit(user, amount);
			}
			else if (userInput.Equals("2"))
			{
				Console.WriteLine("How much you wan commot?");
				int amount = Convert.ToInt32(Console.ReadLine());

				savings.Withdraw(user, amount);
			}
			else if (userInput.Equals("3"))
			{
				savings.GetAccountBalance(user);
			}

		}
	}
}
	
