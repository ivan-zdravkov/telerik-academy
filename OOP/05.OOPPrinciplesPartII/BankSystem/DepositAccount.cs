using System;

namespace BankSystem
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer client, double balance, double interestRate) : base(client, balance, interestRate) { }

        public void Withdraw (double amount)
        {
            if (!(this.Balance - amount < 0))
            {
                this.Balance -= amount;
            }
            else
            {
                throw new ArgumentException("There is not enough money in the account to make the withdraw!");
            }
        }

        public override double CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentException("You need to enter a possitive number in order to calculate Interest!");
            }
            else
            {
                if (this.Balance < 1000)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterest(numberOfMonths);
                }
            }
        }
    }
}
