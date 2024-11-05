using System;
using Bank.AccountOwner;

namespace Bank.Account
{
    internal class Account
    {
        private float balance;
        public AccountOwner.AccountOwner Owner { get; }

        public Account(AccountOwner.AccountOwner owner, float startBalance)
        {
            if (startBalance < 100)
            {
                throw new ArgumentException("Initial balance must be at least 100.");
            }

            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            balance = startBalance;
        }

        public string Deposit(float amount)
        {
            balance += amount; // Using addition assignment operator
            return GetUpdateMessage();
        }

        public string Withdraw(float amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= amount; // Using subtraction assignment operator
            return GetUpdateMessage();
        }

        public float ShowBalance()
        {
            return balance;
        }

        private string GetUpdateMessage()
        {
            return $"Din konto er blevet opdateret. Der står nu kr. {balance}.";
        }
    }
}
