using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
	public class StartPage
	{
		public static void SignUp()
		{
			Console.WriteLine("Please fill out the form below");
			Console.WriteLine("First Name");
			string firstname = Console.ReadLine();
			firstname = testString(firstname);

			Console.WriteLine("Last Name");
			string lastname = Console.ReadLine();
			lastname = testString(lastname);

			Console.WriteLine("Age");
			int age = Convert.ToInt32(Console.ReadLine());
			age = testInt(age);

			Console.WriteLine("Gender");
			string gender = Console.ReadLine();

			Console.WriteLine("Mail");
			string mail_address = Console.ReadLine();
			mail_address = testMail(mail_address);

			Console.WriteLine("Phone Number");
			int phone_number = Convert.ToInt32(Console.ReadLine());
			phone_number = testInt(phone_number);

			//further modification to the password checking methods would be done later
			Console.WriteLine("Password (this would be used for subsequent logins");
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
				else if (!(value.Contains("@") || value.Contains("."))){
					Console.WriteLine("Email must contain character '@' and '.com' or '.co.uk'");
					Console.WriteLine("E-mail Address");
					value = Console.ReadLine();
				}
			}
		}
	}
}
