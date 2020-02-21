using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Entities.Exceptions;

namespace BankApp.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if(balance <= 0)
            {
                throw new AccountException("Your balance needs to be bigger than 0");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
