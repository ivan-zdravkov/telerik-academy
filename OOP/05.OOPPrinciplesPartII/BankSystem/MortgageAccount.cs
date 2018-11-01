using System;

namespace BankSystem
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer client, double balance, double interestRate) : base(client, balance, interestRate) { }

        public override double CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentException("You need to enter a possitive number in order to calculate Interest!");
            }
            else
            {
                switch (this.Client.GetType().Name)
                {
                    case "Individual":
                        {
                            if (numberOfMonths <= 6)
                            {
                                return 0;
                            }
                            else
                            {
                                return base.CalculateInterest(numberOfMonths - 6);
                            }
                        }
                    case "Company":
                        {
                            if (numberOfMonths <= 12)
                            {
                                return (base.CalculateInterest(numberOfMonths)) / 2;
                            }
                            else
                            {
                                return ((base.CalculateInterest(12) / 2) + base.CalculateInterest(numberOfMonths - 12));
                            }
                        }
                    default:
                        {
                            return base.CalculateInterest(numberOfMonths);
                        }
                }
            }
        }
    }
}
