using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class Bank
    {
        public List <Account> accounts = new List <Account> (); // lista för att behålla alla accounts
        public List<Transaction> transactions = new List <Transaction> (); // samma fast för transactions

        public void CreateAccount(int idNumber, string name) // gör att nytt konto
        {
            Account newAccount = new Account(idNumber, name);
            accounts.Add(newAccount);
        }
        public Account GetAccount(int idNumber) // hitta accotns id number
        {
            return accounts.Find(account => account.IdNumber == idNumber);
        }
        public void PerformTransaction(int idNumber, int amount, bool isDeposit) // för att tra ut eller lägga in pengar
        {
            Account account = GetAccount(idNumber);
            if (account != null)
            {
                if (isDeposit)
                {
                    account.Deposite(amount);
                }
                else
                {
                    account.Withdraw(amount);
                }
                // för att spara alla transactions
                string transactionID = Guid.NewGuid().ToString();
                Transaction transaction = new Transaction(transactionID, idNumber, amount);
                transactions.Add(transaction);
            }
            else return;
        }
    }
}
