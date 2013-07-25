//Task 3 - A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program that reads 
//the information about a company and its manager and prints them on the console.

using System;

class ReadInformationAboutCompany
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter company's manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter company's manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter company's manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter company's manager phone number:");
        string managerNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company name : {0}",companyName);
        Console.WriteLine("Company address: {0}",companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhoneNumber); 
        Console.WriteLine("Company fax number: {0}",companyFaxNumber);
        Console.WriteLine("Company website: https://{0}", companyWebsite);
        Console.WriteLine("Company's manager first name: {0}",managerFirstName);
        Console.WriteLine("Comapny's manager last name: {0}",managerLastName);
        Console.WriteLine("Company's manager age: {0}",managerAge);
        Console.WriteLine("Company's manager phone number: {0}",managerNumber);
     }
}
    

