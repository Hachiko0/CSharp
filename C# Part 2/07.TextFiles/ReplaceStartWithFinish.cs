using System;
using System.IO;

/* Write a program that replaces all occurrences 
 * of the substring "start" with the substring "finish"
 * in a text file. Ensure it will work with large files (e.g. 100 MB). */

class Program
{
    static void Main()
    {
        string asd = "starttoplayfifa";
        string asdf = asd.Replace("start", "finish");
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        string replaced = string.Empty;
        using (reader)
        {
            string allText = reader.ReadToEnd();
            replaced = allText.Replace("start", "finish");
        }
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            writer.WriteLine(replaced);
        }
    }
}

