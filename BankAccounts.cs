using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Banking_App
{
	public class BankAccounts : IBankAccounts
	{
		Dictionary<string, Account> currentAccounts;
		public List<Account> ExistingAccounts()
		{
			var account1 = new Savings()
			{
				AccountNumber = "0289281828",
				AccountPassword = "ola",
				Gender = "Male",
				Mail = "Olagesin@gmail.com",
				Name = "Samuel Olagesin",
				PhoneNumber = 0921929391
			};

			var account2 = new Savings()
			{
				AccountNumber = "0289281128",
				AccountPassword = "ola2",
				Gender = "Female",
				Mail = "woman@gmail.com",
				Name = "Sharon Olagesin",
				PhoneNumber = 0921929391
			};

			var account3 = new Current()
			{
				AccountNumber = "0289199828",
				AccountPassword = "ola1",
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

		public Dictionary<string, Account> GetBankAccounts()
		{
			var existingAccounts = ExistingAccounts();
			if(currentAccounts is null)
			{
				currentAccounts = new Dictionary<string, Account>();
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

		public bool AccountExists(string accountNumber)
		{
			var accounts = GetBankAccounts();
			if (accounts.ContainsKey(accountNumber))
				return true;
			return false;
		}

		public bool AccountLoginMatch(string accountNumber, string password)
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

		public Account returnAccount(string accountNumber)
		{
			var accounts = GetBankAccounts();
			return accounts[accountNumber];
		}

	}
}
	
