﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaExemplo.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance,double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
