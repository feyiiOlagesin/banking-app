using System.Collections.Generic;

namespace Banking_App
{
    public class BankAccounts
	{
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

			Dictionary<int, Account> kvp = new Dictionary<int, Account>();

			foreach (var item in existingAccounts)
			{
				kvp.Add(item.AccountNumber, item);
			}
			return kvp;
		}

	}
}
	
