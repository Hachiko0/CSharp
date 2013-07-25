using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Georgiev";
        string fullName = firstName + " " + middleName + " " + lastName;
        decimal balance = 1000000m;
        string bankName = "Fist Investional Bank";
        string IBAN = "BG0GTS61250493";
        string BICCode = "AS12BD";
        long firstCreditCard = 1234567891L;
        long secondCreditCard = 102030405060L;
        long thirdCreditCard = 98765432101L;
        Console.WriteLine("Information about : {0}", fullName);
        Console.WriteLine("Balance : {0}", balance);
        Console.WriteLine("First credit card : {0}", firstCreditCard);
        Console.WriteLine("Second credit card : {0}", secondCreditCard);
        Console.WriteLine("Third credit card : {0}", thirdCreditCard);
    }
}

