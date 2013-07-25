using System;

/* Write a program that reads two arrays from 
 * the console and compares them element by element */
class CompareArrays
{
    static void Main()
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}] = ",i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("secondArray[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0}. {1} > {2}",i,firstArray[i],secondArray[i]);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0}. {1} < {2}", i, firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0}. {1} = {2}",i,firstArray[i],secondArray[i]);
            }
        }
    }
}
