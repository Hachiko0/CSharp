using System;
/* Write a program that creates an array containing all letters 
 * from the alphabet (A-Z). Read a word from the console 
 * and print the index of each of its letters in the array. */

class PrintIndexOfLetters
{
    static void Main()
    {
        int counter = 1;
        char[] alphabet = new char[27];
        for (char w = 'A'; w <= 'Z'; w++,counter++)
        {
            alphabet[counter] = w;
        }
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 1; j < 27; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("{0} = {1}",word[i],j);
                    break;
                }
            }
        }
    }
}

