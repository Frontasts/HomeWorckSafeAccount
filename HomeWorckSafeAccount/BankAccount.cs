namespace HomeWorckSafeAccount
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                _balance = 0;
            }

            _balance = initialBalance;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            _balance = _balance + amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > _balance)
            {
                return false;
            }

            _balance = _balance - amount;
            return true;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}