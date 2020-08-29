namespace Banking_App
{
    public interface IBankAccounts
	{
		bool AccountExists(string accountNumber);

		bool AccountLoginMatch(string accountNumber, string password);

		Account returnAccount(string accountNumber);
	}
}
	
