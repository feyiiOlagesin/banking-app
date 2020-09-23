using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
	public class AccessPage
	{
		public static Account SignUp()
		{
			Console.WriteLine("Please fill out the form below");
			Console.WriteLine("First Name");
			string firstname = Console.ReadLine();
			firstname = testString(firstname);

			Console.WriteLine("Last Name");
			string lastname = Console.ReadLine();
			lastname = testString(lastname);

			var name = firstname + " " + lastname;

			Console.WriteLine("Date of Birth: Year of Birth");
			int YearOfBirth = Convert.ToInt32(Console.ReadLine());
			YearOfBirth = testInt(YearOfBirth);

			Console.WriteLine("Date of Birth: Month of Birth");
			int MonthOfBirth = Convert.ToInt32(Console.ReadLine());
			MonthOfBirth = testInt(MonthOfBirth);

			Console.WriteLine("Date of Birth: Month of Birth");
			int DayOfBirth = Convert.ToInt32(Console.ReadLine());
			DayOfBirth = testInt(DayOfBirth);

			var Birthdate = new DateTime(YearOfBirth, MonthOfBirth, DayOfBirth);

			Console.WriteLine("Gender");
			string gender = Console.ReadLine();

			Console.WriteLine("Mail");
			string mail_address = Console.ReadLine();
			mail_address = testMail(mail_address);

			Console.WriteLine("Phone Number");
			int phone_number = Convert.ToInt32(Console.ReadLine());
			phone_number = testInt(phone_number);

			//modified it to make sure the length is greater than 8
			Console.WriteLine("Password (this would be used for subsequent logins");
			string password = Console.ReadLine();
			password = testPassword(password);

			Console.WriteLine("Account Type: \n 1. Savings Account\n 2. Current Account");
			var account_type = Console.ReadLine();
			var accountObject = ReturnAccountType(account_type, name, Birthdate, gender, mail_address, phone_number, password);

			return accountObject;
		}

		public static Account ReturnAccountType(string account_type, string name, DateTime birthdate, string gender, string mail_address, int phone_number, string password)
		{
			Random random = new Random();
				if (account_type.Equals("1"))
				{
					var savings = new Savings()
					{
						Name = name,
						Birthdate = birthdate,
						Gender = gender,
						Mail = mail_address,
						PhoneNumber = phone_number,
						AccountPassword = password,
						AccountBalance = 0.0,
						AccountNumber = "02" + Convert.ToInt32(random.Next(19999999, 99999999)),
						AccountType = "Savings"
					};
				return savings;
			}
			else if(account_type.Equals("2"))
			{
				var current = new Current()
				{
					Name = name,
					Birthdate = birthdate,
					Gender = gender,
					Mail = mail_address,
					PhoneNumber = phone_number,
					AccountPassword = password,
					AccountBalance = 0.0,
					AccountNumber = "02" + Convert.ToInt32(random.Next(19999999, 99999999)),
					AccountType = "Current"
				};
				return current;
			}
			else
			{
				return null;
			}
		}

		// the interface is applied so as to reduce tight coupling between the method and bankAccounts
		// You can change it if you want, it's quite flexible.... i think.
		public static Account Login(IBankAccounts bankAccounts, string accountNumber, string password)
		{
			var checkExistence = bankAccounts.AccountExists(accountNumber);
			if (checkExistence)
			{
				var checkDetails = bankAccounts.AccountLoginMatch(accountNumber, password);
				if (checkDetails)
				{
					var UserAccount = bankAccounts.returnAccount(accountNumber);
					return UserAccount;
				}
			}
			return null;
		}

		// Test Methods
		private static string testString(string value) {
			int temp;
			while (true)
			{
				if (value.Equals(""))
				{
					Console.WriteLine("Invalid Input, field cannot be empty,\n input your details");
					value = Console.ReadLine();
				}

				else if (int.TryParse(value, out temp))
				{
					Console.WriteLine("Value cannot be an integer, \ninput your details");
					value = Console.ReadLine();
				}
				else {
					break;				
				}
			}
			return value;
		}

		private static int testInt(int value) {
			while (true) {
				if (value.Equals(""))
				{
					Console.WriteLine("Invalid Input, field cannot be empty,\n input your details");
					value = Convert.ToInt32(Console.ReadLine());
				}
				else {
					break;
				}
			}
			return value;
		}

		private static string testMail(string value) {
			while (true) {
				if (value.Equals(""))
				{
					Console.WriteLine("Invalid Input, field cannot be empty,\n input your details");
					value = Console.ReadLine();
				}
				else if (!(value.Contains("@") && value.Contains("."))){
					Console.WriteLine("Email must contain character '@' and '.com' or '.co.uk'");
					Console.WriteLine("E-mail Address");
					value = Console.ReadLine();
				}
				else
				{
					break;
				}
			}
			return value;
		}

		private static string testPassword(string value)
		{
			while (true)
			{
				if(value.Length < 8) 
				{
					Console.WriteLine("Password has to be longer than 8 digits");
					Console.Write("Password");
					value = Console.ReadLine();
				}
				else
				{
					break;
				}
			}
			return value;
		}
	}
}
