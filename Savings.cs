using System;
namespace Banking_App
{
    public class Savings : Account
	{
		public override void Deposit(int amount)
		{
			if (amount < 100.0 || amount > 20000)
			{
				Console.WriteLine("Invalid amount, please try again");
			}
			else
			{
				AccountBalance = amount + AccountBalance;
				Console.WriteLine("Transaction Successful");
			}
		}

		public override void Withdraw(int amount)
		{
			if (AccountBalance < amount)
			{
				Console.WriteLine("Insufficient Funds Available");
			}
			else
			{
				AccountBalance = AccountBalance - amount;
				Console.WriteLine("Transaction Successful");
			}
		}
		public override double GetAccountBalance()
		{
			return AccountBalance;
		}
	}
}
	
