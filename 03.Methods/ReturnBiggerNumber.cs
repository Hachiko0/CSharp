using System;

/*Write a method GetMax() with two parameters 
 * that returns the bigger of two integers. Write 
 * a program that reads 3 integers from the console
 * and prints the biggest of them using the method GetMax(). */

class ReturnBiggerNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else return secondNumber;
        //we dont check if they are equal because the task does not mention they can be equal
    }
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int biggest = GetMax(GetMax(first, second), third);
        Console.Write("The biggest number is : ");
        Console.WriteLine(biggest);
    }
}

