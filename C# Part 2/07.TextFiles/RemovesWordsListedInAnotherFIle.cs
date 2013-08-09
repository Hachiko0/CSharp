using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

/* Write a program that removes from a text file 
 * all words listed in given another text file. 
 * Handle all possible exceptions in your methods. */

class RemovesWordsListedInAnotherFIle
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines(@"..\..\words.txt");
            string regex = @"\b(" + String.Join("|", words) + @")\b";
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string replaced = Regex.Replace(line, regex, string.Empty);
                        line = reader.ReadLine();
                        writer.WriteLine(replaced);
                    }
                }
            }
        }
        catch (FileNotFoundException fileNotFound)
        {
            Console.WriteLine(fileNotFound.Message);
        }
        catch (DirectoryNotFoundException directoryNotFound)
        {
            Console.WriteLine(directoryNotFound.Message);
        }
        catch (IOException IOexception)
        {
            Console.WriteLine(IOexception.Message);
        }
        catch (SecurityException security)
        {
            Console.WriteLine(security.Message);
        }
        catch (UnauthorizedAccessException unauthorized)
        {
            Console.WriteLine(unauthorized.Message);
        }
    }
}
