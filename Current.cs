using System;

namespace Banking_App
{
    public class Current : Account
	{
		public override void Deposit(int amount)
		{
			Console.WriteLine(Name);
		}

		public override void Withdraw(int amount)
		{

		}
	}
}
	
