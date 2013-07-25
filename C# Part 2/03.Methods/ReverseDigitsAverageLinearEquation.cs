using System;

class ReverseDigitsAverageLinearEquation
{
    static int Menu()
    {
        string menu = "Menu";
        Console.WriteLine("{0,27}", menu);
        Console.WriteLine(new string('=', 50));
        Console.WriteLine();
        Console.WriteLine("1.Reverse the digits of a number");
        Console.WriteLine("2.Calculate the average of a sequence of integers");
        Console.WriteLine("3.Solves a linear equation");
        Console.WriteLine();
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("Please enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    static int ValidateReverse(int number)
    {
        do
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("The number must be bigger than 0, try again");
            }
        } while (number <= 0);
        return number;
    }
    static void ValidateEquation()
    {
        int a = 0;
        do
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a must be different from 0");
            }
        } while (a == 0);
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Equation(a,b));
    }
    static int ReverseDigits()
    {
        int number = 0;
        number = ValidateReverse(number);
        string ReversedNumber = string.Empty;
        while (number > 0)
        {
            ReversedNumber += number % 10;
            number = number / 10;
        }
        return int.Parse(ReversedNumber);

    }
    static double AverageSequence()
    {
        Console.WriteLine("Enter the length of the array: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        if (arr.Length == 0)
        {
            Console.WriteLine("Wrong input !");
            return -1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int average = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            average += arr[i];
        }
        return (double)average / arr.Length;
    }
    static double Equation(int a,int b)
    {
        return (double)-b / a;
    }
    static void Main()
    {
        int choice = Menu();
        if (choice == 1)
        {
            Console.WriteLine("Reversed number: ");
            Console.WriteLine(ReverseDigits());
        }
        else if (choice == 2)
        {
            Console.WriteLine("Average of a sequence: ");
            Console.WriteLine(AverageSequence());
        }
        else if (choice == 3)
        {
            ValidateEquation();
        }
    }
}
