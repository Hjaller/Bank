using System;

namespace Bank.AccountOwner
{
    internal class AccountOwner
    {
        public int CustomerId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }

        public AccountOwner(int customerId, string firstName, string lastName)
        {
            if (customerId.ToString().Length != 6)
            {
                throw new ArgumentException("CustomerId must be a 6-digit number.");
            }

            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{FirstName} {LastName}";
        }
    }
}
