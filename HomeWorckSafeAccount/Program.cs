using System;

namespace HomeWorckSafeAccount
{
    internal class Program
    {
        public static void Main() 
        {
            BankAccount account = new BankAccount(1000);

            Console.WriteLine($"Текущий баланс: {account.GetBalance()}");
            Console.WriteLine();

            Console.WriteLine(account.Deposit(500));
            Console.WriteLine(account.Deposit(-100));
            Console.WriteLine();

            Console.WriteLine(account.Withdraw(300));
            Console.WriteLine(account.Withdraw(2000));
            Console.WriteLine(account.Withdraw(-50));
            Console.WriteLine();

            Console.WriteLine($"Итоговый баланс: {account.GetBalance()}");
        }
    }
}