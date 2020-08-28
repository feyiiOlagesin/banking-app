namespace Banking_App
{
    public interface IBankAccounts
	{
		bool AccountExists(int accountNumber);

		bool AccountLoginMatch(int accountNumber, string password);

		Account returnAccount(int accountNumber);
	}
}
	
