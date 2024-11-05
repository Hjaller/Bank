namespace Bank
{
    public sealed class AccountAdmin : Person
    {
        public int EmployeeId { get; }

        public AccountAdmin(int employeeId, string firstName, string lastName)
            : base(firstName, lastName)
        {
            EmployeeId = employeeId;
        }
    }
}