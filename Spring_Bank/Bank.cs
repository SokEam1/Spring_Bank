using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring_Bank
{
    public class Bank
    {
        Dictionary<string, Account> bankAccounts = new Dictionary<string, Account>();

        public Dictionary<string, Account> BankAccounts { get; set; }

        public Bank(Dictionary<string, Account> accounts)
        {
            BankAccounts = bankAccounts;
        }

        public Dictionary<string, Account> GetAllAccounts()
        {
            return BankAccounts;
        }

        public void openNewAccount(Account account)
        {
            BankAccounts.Add(account.AccountType, account);
        }

        public Account getAccount(string accountType)
        {
            return BankAccounts[accountType];
        }

        public void closeAccount(Account account)
        {
            if (bankAccounts.ContainsKey(account.AccountType))
            {
                BankAccounts.Remove(account.AccountType);
            }
            
        }
    }
}
