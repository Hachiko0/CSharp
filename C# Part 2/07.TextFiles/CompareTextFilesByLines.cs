using System;
using System.IO;

/* Write a program that compares two text files
 * line by line and prints the number of lines that 
 * are the same and the number of lines that are different.
 * Assume the files have equal number of lines. */

class CompareTextFilesByLines
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;
        StreamReader firstReader = new StreamReader(@"..\..\firstFile.txt");
        using (firstReader)
        {
            StreamReader secondReader = new StreamReader(@"..\..\secondFile.txt");
            using (secondReader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");
                using (writer)
                {
                    string firstFile = firstReader.ReadLine();
                    string secondFile = secondReader.ReadLine();
                    while (firstFile != null)
                    {
                        if (firstFile == secondFile) sameLines++;
                        else differentLines++;
                        firstFile = firstReader.ReadLine();
                        secondFile = secondReader.ReadLine();
                    }
                }
            }
        }
        Console.WriteLine("{0} same lines",sameLines);
        Console.WriteLine("{0} different lines",differentLines);
    }
}
