using System;
using Bank.Account;
using Bank.AccountOwner;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Opret en konto:\n");

                Console.Write("Indtast kundenummer: ");
                int customerId;
                while (!int.TryParse(Console.ReadLine(), out customerId) || customerId.ToString().Length != 6)
                {
                    Console.Write("Ugyldigt kundenummer. Indtast et 6-cifret nummer: ");
                }

                Console.Write("Indtast fornavn: ");
                string firstName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.Write("Fornavn må ikke være tomt. Indtast fornavn: ");
                    firstName = Console.ReadLine();
                }

                Console.Write("Indtast efternavn: ");
                string lastName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.Write("Efternavn må ikke være tomt. Indtast efternavn: ");
                    lastName = Console.ReadLine();
                }

                Console.Write("Indtast startbalance: ");
                float startBalance;
                while (!float.TryParse(Console.ReadLine(), out startBalance) || startBalance < 100)
                {
                    Console.Write("Ugyldig startbalance. Indtast et tal større end eller lig med 100: ");
                }

                try
                {
                    AccountOwner.AccountOwner owner = new AccountOwner.AccountOwner(customerId, firstName, lastName);
                    Account.Account myAccount = new Account.Account(owner, startBalance);
                    Console.WriteLine($"Account Owner: {owner.FullName}");
                    Console.WriteLine("Initial Balance: " + myAccount.ShowBalance());

                    Console.WriteLine(myAccount.Deposit(50));
                    Console.WriteLine("Balance after deposit: " + myAccount.ShowBalance());

                    Console.WriteLine(myAccount.Withdraw(100));
                    Console.WriteLine("Balance after withdrawal: " + myAccount.ShowBalance());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
