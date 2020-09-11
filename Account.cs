using System;

namespace Banking_App
{
	public abstract class Account
	{
		public string Name { get; set; }
		public DateTime Birthdate { get; set; }
		public string Gender { get; set; }
		public string Mail { get; set; }
		public int PhoneNumber { get; set; }
		public string AccountNumber { get; set; }
		public double AccountBalance { get; set; }
		public string AccountType { get; set; }
		public string AccountPassword { get; set; }


		public abstract void Withdraw(Account user, int amount);

		public abstract void Deposit(Account user, int amount);

		public abstract double GetAccountBalance(Account user);
	}
}
	
