using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6_OpOverloading
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        public static BankAccount operator +(BankAccount bank1,BankAccount bank2)
        {
            double newAmountMoney = bank1.Money + bank2.Money;
            string newOwner = bank1.Owner + " + " + bank2.Owner;

            BankAccount newBankAccount = new BankAccount(newAmountMoney, newOwner);
            return newBankAccount;
        }

        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmountMoney = bank1.Money + amount;
            string newOwner = bank1.Owner;

            BankAccount newBankAccount = new BankAccount(newAmountMoney, newOwner);
            return newBankAccount;
        }

    }
}
