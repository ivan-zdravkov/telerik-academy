// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyManager
{
    static void Main()
    {
        Console.Write("Enter the name of the company: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter the address of the company: ");
        string address = Console.ReadLine();
        Console.Write("Enter the phone number of the company: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter the fax number of the company: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter the company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter the manager's first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Enter the manager's last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Enter the manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter the manager's phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n{0}\nAddress: {1}\nPhone: {2}\nFax: {3}\nWeb Site: {4}\n",
            companyName, address, phoneNumber, faxNumber, webSite);
        Console.WriteLine("Manager: {0} {1}, {2}\nPhone: {3}", 
            managerFName, managerLName, managerAge, managerPhone);
    }
}

