/* A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics – 
 * first name, family name, age, gender (m or f), ID number, 
 * unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for 
 * a single employee using appropriate data types and descriptive names.
 */

using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName = "Pesho";
        string lastName = "Peshov";
        byte age = 20;
        char gender = 'M';
        long idNumber = 35482722890044;
        int uniqueNumber = 27560050;
        Console.WriteLine(firstName + " " + lastName + "\n" + gender + ", " + age +
            "\nID Number: " + idNumber + "\nUnique Employee Number: " + uniqueNumber);
    }
}
