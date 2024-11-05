namespace Bank
{
    public sealed class AccountOwner : Person
    {
        public int CustomerId { get; }

        public AccountOwner(int customerId, string firstName, string lastName)
            : base(firstName, lastName)
        {
            CustomerId = customerId;
        }
    }
}