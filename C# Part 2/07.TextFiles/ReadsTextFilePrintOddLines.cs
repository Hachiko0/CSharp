using System;
using System.IO;

/* Write a program that reads a text file and prints on the console its odd lines. */

class ReadsTextFilePrintOddLines
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter("proba.txt"); // write the numbers from 1 to 100 in the file
        using (writer)
        {
            for (int i = 1; i <= 100; i = i + 10)
            {
                for (int j = i; j < i + 10; j++)
                {
                    writer.Write("{0,4}", j);
                }
                writer.WriteLine();
            }
        }
        StreamReader reader = new StreamReader("proba.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0) // print the odd lines from the file to the console
                {
                    Console.WriteLine(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}

