using System;

namespace HomeWorckSafeAccount
{
    internal class Program
    {
        static void Main()
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
	
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            string result = SetBalance(initialBalance);
            bool validBalance = result.StartsWith("Ошибка");
            if (validBalance)
            {
                _balance = 0;
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        private string SetBalance(decimal amount)
        {
            string result;
			
            if (amount < 0)
            {
                result = "Ошибка: баланс не может быть отрицательным";
            }
            else
            {
                _balance = amount;
                result = $"Баланс установлен: {_balance}";
            }
			
            return result;
        }

        public string Deposit(decimal amount)
        {
            string result;
			
            if (amount <= 0)
            {
                result = "Ошибка: сумма пополнения должна быть положительной";
            }
            else
            {
                _balance = _balance + amount;
                result = $"Пополнение: +{amount}. Текущий баланс: {_balance}";
            }
			
            return result;
        }

        public string Withdraw(decimal amount)
        {
            string result;
			
            if (amount <= 0)
            {
                result = "Ошибка: сумма снятия должна быть положительной";
            }
            else if (amount > _balance)
            {
                result = "Ошибка: недостаточно средств";
            }
            else
            {
                _balance = _balance - amount;
                result = $"Снятие: -{amount}. Текущий баланс: {_balance}";
            }
			
            return result;
        }
    }

}
