using System;

namespace BankSystem
{
    public abstract class Account : IDepositable
    {
        public Customer Client { get; set; }
        public double Balance { get; set; }
        public double interestRate { get; set; }

        public Account (Customer client, double balance, double interestRate)
        {
            this.Client = client;

            if (!(balance < 0))
            {
                this.Balance = balance;
            }
            else
            {
                throw new ArgumentException("You cannot have a negative balance!");
            }
            this.interestRate = interestRate;
        }

        public virtual double CalculateInterest(int numberOfMonths) 
        {
            return numberOfMonths * this.interestRate;
        }

        public void Deposit(double amount)
        {
            if (!(amount < 0))
            {
                this.Balance += amount;
            }
            else
            {
                throw new ArgumentException("The amount you deposit cannot be less than zero!");
            }
        }
    }
}
