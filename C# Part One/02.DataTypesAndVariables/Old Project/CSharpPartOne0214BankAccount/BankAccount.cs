//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
// IBAN, BIC code and 3 credit card numbers associated with the account. 
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Peshov";
        string lastName = "Peshov";
        decimal balance = 560.20M;
        string bankName = "Reiffeisen Bank";
        string IBAN = "RB 20 A4F3 0021 2556 B3E6 90";
        string BIC = "RZBBBGSF";
        long creditCard1 = 1234567893511352;
        long creditCard2 = 1351362462462462;
        long creditCard3 = 1356136462475421;
        Console.WriteLine("{0} {1} {2}\n{3} {4}\nIBAN: {5}\nBalance:{6}\n\nCredit Card numbers:\n{7}\n{8}\n{9}",
            firstName, middleName, lastName, bankName, BIC, IBAN, balance, creditCard1, creditCard2, creditCard3);
    }
}

