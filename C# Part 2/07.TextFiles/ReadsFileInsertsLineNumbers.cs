using System;
using System.IO;

/* Write a program that reads a text file and inserts 
 * line numbers in front of each of its lines. The result 
 * should be written to another text file. */

class ReadsFileInsertsLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\inputFile.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\outputFile.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    writer.Write("Line {0}: ", lineNumber);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
