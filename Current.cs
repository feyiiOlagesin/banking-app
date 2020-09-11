using System;

namespace Banking_App
{
    public class Current : Account
	{
		public override void Deposit(Account user, int amount)
		{
			if(amount < 100.0 || amount > 20000)
			{
				Console.WriteLine("Invalid amount, please try again");
			}
			else
			{
				user.AccountBalance = amount + user.AccountBalance;
				Console.WriteLine("Transaction Successful");
			}
		}

		public override void Withdraw(Account user, int amount)
		{
			if(user.AccountBalance < amount)
			{
				Console.WriteLine("Insufficient Funds Available");
			}
			else
			{
				user.AccountBalance = user.AccountBalance - amount;
				Console.WriteLine("Transaction Successful");
			}
		}

		public override double GetAccountBalance(Account user)
		{
			return user.AccountBalance;
		}


	}
}
	
