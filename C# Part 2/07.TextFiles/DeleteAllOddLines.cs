using System;
using System.IO;
using System.Collections.Generic;
/* Write a program that deletes from given
 * text file all odd lines. The result should be in the same file. */

class DeleteAllOddLines
{
    static void Main()
    {
        List<string> evenLines = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int linesNumber = 0;
            while (line != null)
            {
                if (linesNumber % 2 == 0)
                {
                    evenLines.Add(line);
                }
                linesNumber++;
                line = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\input.txt");
        using (writer)
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.WriteLine(evenLines[i]);
            }
        }
    }
}
