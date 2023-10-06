using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account_sign_up
{
    internal class BankAccount
    {
        public int Number { get; private set; }
        public string Owner { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public BankAccount(int number, string owner, double balance) : this(number, owner)
        {
            Balance = balance;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void Draft(double ammount)
        {
            Balance -= ammount + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Number + ", Titular: " + Owner + ", Saldo: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
