using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Banking_App
{
    public class BankAccounts
	{
		Dictionary<int, Account> currentAccounts;
		public List<Account> ExistingAccounts()
		{
			var account1 = new Savings()
			{
				AccountNumber = 1289281828,
				Gender = "Male",
				Mail = "Olagesin@gmail.com",
				Name = "Samuel Olagesin",
				PhoneNumber = 0921929391
			};

			var account2 = new Savings()
			{
				AccountNumber = 1289281128,
				Gender = "Female",
				Mail = "woman@gmail.com",
				Name = "Sharon Olagesin",
				PhoneNumber = 0921929391
			};

			var account3 = new Current()
			{
				AccountNumber = 1289199828,
				Gender = "Female",
				Mail = "lady@gmail.com",
				Name = "stephanie Olagesin",
				PhoneNumber = 0921929391
			};

			var customers = new List<Account>();
			customers.Add(account1);
			customers.Add(account2);
			customers.Add(account3);

			return customers;
		}

		public Dictionary<int, Account> GetBankAccounts()
		{
			var existingAccounts = ExistingAccounts();
			if(currentAccounts.Count == 0)
			{
				currentAccounts = new Dictionary<int, Account>();
				foreach (var item in existingAccounts)
				{
					currentAccounts.Add(item.AccountNumber, item);
				}
			}
			else
			{
				foreach (var item in existingAccounts)
				{
					if (currentAccounts.ContainsKey(item.AccountNumber))
					{
						continue;
					}
					else
					{
						currentAccounts.Add(item.AccountNumber, item);
					}
				}
			}
			return currentAccounts;
		}

		public bool AccountExists(int accountNumber)
		{
			var accounts = GetBankAccounts();
			if (accounts.ContainsKey(accountNumber))
				return true;
			return false;
		}

		public bool AccountLoginMatch(int accountNumber, string password)
		{
			var accounts = GetBankAccounts();
			foreach (var item in accounts.Values)
			{
				if((item.AccountNumber == accountNumber) && (item.AccountPassword.Equals(password)))
				{
					return true;
				}
			}
			return false;
		}

		public Account returnAccount(int accountNumber)
		{
			var accounts = GetBankAccounts();
			return accounts[accountNumber];
		}

	}
}
	
