﻿using System;
using Ex.Entities.Exceptions;

namespace Ex.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if((Balance > amount && WithdrawLimit > amount))
            {
                Balance -= amount;
            }
            else if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            else if(WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            
        }
    }
}
