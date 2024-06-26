﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    public class Account
    {
        public int IdNumber { get; set; } 
        public string Name { get; set; }
        public int Balance { get; set; }

        public Account(int idNumber, string name) 
        {
            IdNumber = idNumber;
            Name = name;
            Balance = 0; // Balance börjar på 0
        }
        public void Deposite(int amount)  // du kan lägga in pengar i kontot
        { 
            if (0 < amount)
            {
                Balance += amount;
            }
            else 
            {
                return;
            }
        }
        public void Withdraw(int amount) // du kan ta ut pengar i kontot
        {
            if (Balance >= amount && amount > 0)
            {
                Balance -= amount;
            }
            else 
            { 
                return; 
            }
        }
    }
}
