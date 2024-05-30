using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class Transaction
    {
        public string TransactionID {  get; set; }
        public int IdNumber { get; set; }
        public int Amount { get; set; }

        public Transaction(string transactionID, int idNumber, int amount) 
        {
            TransactionID = transactionID;
            IdNumber = idNumber;
            Amount = amount;

        }
    }
}
