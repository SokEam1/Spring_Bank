using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring_Bank
{
    public class Account
    {
        private int accountNumber;
        private string accountType;
        private double accountBalance;

        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }

        public Account(int accountNumber, double accountBalance, string AccountType)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;

        }

        public void Deposit(double money)
        {
            AccountBalance = AccountBalance + money;
        }

        public void Withdrawl(double money)
        {
            AccountBalance = AccountBalance - money;
        }

        public void CheckAccount()
        {
            Console.WriteLine("Your available balance is " + AccountBalance);
        }
    }
}
