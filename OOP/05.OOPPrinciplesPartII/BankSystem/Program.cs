using System;

namespace BankSystem
{
    class Program
    {
        static void Main()
        {
            Account[] accounts = 
            {
                new LoanAccount(new Individual("Toshu", 10), 200, 10),
                new LoanAccount(new Company("Telerik", 11), 14000, 10),
                new DepositAccount(new Individual("Pesho", 12), 800, 10),
                new DepositAccount(new Company("Terlik", 13), 2400, 10),
                new MortgageAccount(new Individual("Goshku", 14), 120, 10),
                new MortgageAccount(new Company("Perfect LTD", 15), 1200, 10)
            };

            accounts[2].Deposit(100);
            // accounts[2].Withdraw(200); This does not work, since I cannot acces the withdraw method from the base class, since it does not support the IWithdawable Interface!

            foreach (Account account in accounts)
            {
                Console.WriteLine("The interest of {0} for {1} is {2}", account.GetType().Name, account.Client.GetType().Name, account.CalculateInterest(10));
            }

            Console.WriteLine("\nCreating a personal deposit savings account...");
            DepositAccount mySavings = new DepositAccount(new Individual("Ivan", 1200), 2300, 10); 
            Console.WriteLine("DONE!");
            PrintAccountInfo(mySavings);

            Deposit(mySavings, 4000);
            Withdraw(mySavings, 600);
        }

        private static void Deposit(DepositAccount mySavings, double amount)
        {
            Console.WriteLine("Depositing {0}...", amount);
            mySavings.Deposit(amount);
            Console.WriteLine("DONE!");
            PrintAccountInfo(mySavings);
        }

        private static void Withdraw(DepositAccount mySavings, double amount)
        {
            Console.WriteLine("Withdrawing {0}...", amount);
            mySavings.Withdraw(amount);
            Console.WriteLine("DONE!");
            PrintAccountInfo(mySavings);
        }

        private static void PrintAccountInfo(DepositAccount mySavings)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Account type: {0} ({1})", mySavings.GetType().Name, mySavings.Client.GetType().Name);
            Console.WriteLine("Account balance: {0}", mySavings.Balance);
            for (int numberOfMonths = 6; numberOfMonths <= 24; numberOfMonths += 6)
            {
                Console.WriteLine("Interest for {0} months: {1}", numberOfMonths, mySavings.CalculateInterest(numberOfMonths));
            }
            Console.WriteLine(new String ('=', 60));
        }
    }
}
