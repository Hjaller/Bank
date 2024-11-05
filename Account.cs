using System;

namespace Bank
{
    internal class Account
    {
        private float balance;
        public AccountOwner Owner { get; }
        public AccountAdmin Admin { get; }

        public Account(AccountOwner owner, AccountAdmin admin, float startBalance)
        {
            if (startBalance < 100)
            {
                throw new ArgumentException("Initial balance must be at least 100.");
            }

            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            Admin = admin ?? throw new ArgumentException(nameof(admin));
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


