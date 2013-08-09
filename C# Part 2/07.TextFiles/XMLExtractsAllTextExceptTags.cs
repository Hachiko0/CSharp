using System;
using System.IO;

/* Write a program that extracts from given XML file all the text without the tags. Example: */

class XMLExtractsAllTextExceptTags
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            for (int i; (i = reader.Read()) != -1; ) 
            {
                if (i == '>') // Inside text node
                {
                    string text = String.Empty;

                    while ((i = reader.Read()) != -1 && i != '<') text += (char)i;

                    if (!String.IsNullOrWhiteSpace(text)) Console.WriteLine(text.Trim());
                }
            }
        }
    }
}