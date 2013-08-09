using System;
using System.IO;
using System.Text.RegularExpressions;

/* Write a program that deletes from a text file all
 * words that start with the prefix "test". Words contain
 * only the symbols 0...9, a...z, A…Z, _. */

class DeleteWordsWithPrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../input.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    line = reader.ReadLine();
                }
            }
        }
    }
}