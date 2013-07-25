using System;

class DevideBy5And7WithoutRemainder
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool noRemainder = (number % 5 == 0 && number % 7 == 0); // first option
        bool noRemainder1 = (number % (5 * 7) == 0); //second option
        if (noRemainder)
        {
            Console.WriteLine("{0} can be devided without remainder by 5 and 7", number);
        }
        else
        {
            Console.WriteLine("{0} can't be devided without remainder by 5 and 7", number);
        }
        if (noRemainder1)
        {
            Console.WriteLine("{0} can be devided without remainder by 5 and 7", number);
        }
        else
        {
            Console.WriteLine("{0} can't be devided without remainder by 5 and 7", number);
        }
    }
}
