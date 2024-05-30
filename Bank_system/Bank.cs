using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class Bank
    {
        public List <Account> accounts = new List <Account> ();
        public List<Transaction> transactions = new List <Transaction> ();

        public void CreateAccount(int idNumber, string name)
        {
            Account newAccount = new Account(idNumber, name);
            accounts.Add(newAccount);
        }
        public Account GetAccount(int idNumber) 
        { 
            return accounts.Find(account => account.IdNumber == idNumberNumber)
        }
    }
}
