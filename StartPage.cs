using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
	public class StartPage
	{
		public static ArrayList SignUp()
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

			//further modification to the password checking methods would be done later
			//modified it to make sure the length is greater than 8
			Console.WriteLine("Password (this would be used for subsequent logins");
			string password = Console.ReadLine();
			password = testPassword(password);

			var details = new ArrayList();
			details.Add(name);
			details.Add(Birthdate);
			details.Add(gender);
			details.Add(mail_address);
			details.Add(phone_number);
			details.Add(password);

			return details;
		}

		public static void Login()
		{
			Console.Write("Username: ");
			string username = Console.ReadLine();
			Console.Write("Password: ");
			string password = Console.ReadLine();
		}

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
