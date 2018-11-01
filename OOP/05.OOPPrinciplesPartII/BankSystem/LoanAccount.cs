using System;

namespace BankSystem
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer client, double balance, double interestRate) : base(client, balance, interestRate) { }

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
                            if (numberOfMonths <= 3)
                            {
                                return 0;
                            }
                            else
                            {
                                return base.CalculateInterest(numberOfMonths - 3);
                            }
                        }
                    case "Company":
                        {
                            if (numberOfMonths <= 2)
                            {
                                return 0;
                            }
                            else
                            {
                                return base.CalculateInterest(numberOfMonths - 2);
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
