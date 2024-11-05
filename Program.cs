using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AccountAdmin admin = new AccountAdmin(234567, "John", "Doe");
            AccountOwner owner = new AccountOwner(123456, "Jane", "Doe");

            Account myAccount = new Account(owner, admin, 100);
            Console.WriteLine($"Hej {myAccount.Owner.FullName}. Din konto er oprettet med {myAccount.Admin.FullName} som admin.");

            Console.WriteLine($"{myAccount.Deposit(100)}");
            Console.WriteLine($"Balance after deposit: {myAccount.ShowBalance()}");

            Console.WriteLine($"{myAccount.Withdraw(50)}");
            Console.WriteLine($"Balance after withdrawal: {myAccount.ShowBalance()}");


            /*Account.Account? myAccount = null;

            while (true)
            {
                Console.WriteLine("Velkommen til banken!");
                Console.WriteLine("Tryk på en tast O, for at oprette en konto.");
                Console.WriteLine("Tryk på en tast I, for at indbetale penge.");
                Console.WriteLine("Tryk på en tast U, for at hæve penge.");
                Console.WriteLine("Tryk på en tast A, for at afslutte.");

                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.O:
                        Console.WriteLine("Opret en konto:");

                        Console.Write("Indtast kundenummer: ");
                        int customerId;
                        while (!int.TryParse(Console.ReadLine(), out customerId) || customerId.ToString().Length != 6)
                        {
                            Console.Write("Ugyldigt kundenummer. Indtast et 6-cifret nummer: ");
                        }

                        Console.Write("Indtast fornavn: ");
                        string? firstName = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(firstName))
                        {
                            Console.Write("Fornavn må ikke være tomt. Indtast fornavn: ");
                            firstName = Console.ReadLine();
                        }

                        Console.Write("Indtast efternavn: ");
                        string? lastName = Console.ReadLine();
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
                            myAccount = new Account.Account(owner, startBalance);
                            Console.WriteLine($"Hej {owner.FullName}, din konto er oprettet.");
                            Console.WriteLine("Initial Balance: " + myAccount.ShowBalance());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case ConsoleKey.I:
                        if (myAccount == null)
                        {
                            Console.WriteLine("Du skal oprette en konto først.");
                            break;
                        }

                        Console.Write("Indtast beløb til indbetaling: ");
                        float depositAmount;
                        while (!float.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                        {
                            Console.Write("Ugyldigt beløb. Indtast et positivt tal: ");
                        }

                        Console.WriteLine(myAccount.Deposit(depositAmount));
                        Console.WriteLine("Balance after deposit: " + myAccount.ShowBalance());
                        break;

                    case ConsoleKey.U:
                        if (myAccount == null)
                        {
                            Console.WriteLine("Du skal oprette en konto først.");
                            break;
                        }

                        Console.Write("Indtast beløb til hævning: ");
                        float withdrawAmount;
                        while (!float.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                        {
                            Console.Write("Ugyldigt beløb. Indtast et positivt tal: ");
                        }

                        try
                        {
                            Console.WriteLine(myAccount.Withdraw(withdrawAmount));
                            Console.WriteLine("Balance after withdrawal: " + myAccount.ShowBalance());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case ConsoleKey.A:
                        return;

                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }
            }*/
        }
    }
}
