using System;
using System.IO;
using System.Collections.Generic;

/* Write a program that reads a text file containing a list of strings,
 * sorts them and saves them to another text file. Example: 
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter */

class SortStringsInFile
{
    static void Main()
    {
        Console.WriteLine(string.Compare("Peter","Ivan"));
        List<string> names = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            string name = reader.ReadLine();
            while (name != null)
            {
                names.Add(name);
                name = reader.ReadLine();
            }
        }
        for (int i = 0; i < names.Count; i++)
        {
            for (int j =  i + 1; j < names.Count; j++)
            {
                if (string.Compare(names[i],names[j]) == 1)
                {
                    string tmp = names[i];
                    names[i] = names[j];
                    names[j] = tmp;
                }
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            for (int i = 0; i < names.Count; i++) writer.WriteLine(names[i]);
        }
    }
}
