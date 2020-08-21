using System;

namespace Banking_App
{
	public abstract class Account
	{
		public string Name { get; set; }
		public DateTime birthdate { get; }
		public string Gender { get; set; }
		public string Mail { get; set; }
		public int PhoneNumber { get; set; }
		public int AccountNumber { get; set; }
		public double AccountBalance { get; set; }
		public Account AccountType { get; set; }


		public abstract void Withdraw(int amount);

		public abstract void Deposit(int amount);

		public abstract double GetAccountBalance();
	}
}
	
