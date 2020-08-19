namespace Banking_App
{
    public class Savings : Account
	{
		public Savings(string name)
		{
			this.Name = name;
		}
		public override void Withdraw(int amount)
		{
			System.Console.WriteLine(Name);	
		}

		public override void Deposit(int amount)
		{

		}
	}
}
	
