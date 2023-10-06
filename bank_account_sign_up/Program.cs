using System;
using System.Globalization;

namespace bank_account_sign_up
{
    class Program
    { 
        static void Main(string[] args) 
        {
            BankAccount account;

            Console.Write("Entre o núumero da conta bancária: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string owner = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char response = char.Parse(Console.ReadLine());

            if (response == 's' || response == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double initialAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, owner, initialAmount);
            }
            else 
            {
                account = new BankAccount(number, owner);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double ammount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(ammount);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            ammount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Draft(ammount);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);
        }
    }
}
