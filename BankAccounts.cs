using System.Collections.Generic;

namespace Banking_App
{
    public class BankAccounts
	{
		Dictionary<int, Account> account1 = new Dictionary<int, Account>();
		Dictionary<int, Account> account2 = new Dictionary<int, Account>();
		Dictionary<int, Account> account3 = new Dictionary<int, Account>();
		Dictionary<int, Account> account4 = new Dictionary<int, Account>();
		Dictionary<int, Account> account5 = new Dictionary<int, Account>();


		public List<Dictionary<int, Account>> GetBankAccounts()
		{
			var bankAccountsList = new List<Dictionary<int, Account>>();
			bankAccountsList.Add(account1);
			bankAccountsList.Add(account2);
			bankAccountsList.Add(account3);
			bankAccountsList.Add(account4);
			bankAccountsList.Add(account5);

			return bankAccountsList;
		}

	}
}
	
