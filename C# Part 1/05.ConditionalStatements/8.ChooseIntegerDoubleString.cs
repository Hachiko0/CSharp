using System;

class ChooseIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Press 1 for integer: ");
        Console.WriteLine("Press 2 for double: ");
        Console.WriteLine("Press 3 for string: ");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter an integer: ");
                int integerChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(integerChoice + 1); break;
            case 2:
                Console.Write("Enter a real number: ");
                double doubleChoice = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleChoice + 1.0); break;
            case 3:
                Console.Write("Enter a string: ");
                string stringChoice = Console.ReadLine();
                Console.WriteLine(stringChoice + "*"); break;
            default: Console.WriteLine("Wrong data input"); break;
        }
    }
}
