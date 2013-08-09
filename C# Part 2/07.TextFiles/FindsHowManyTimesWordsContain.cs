using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

/* Write a program that reads a list of words from 
 * a file words.txt and finds how many times each of 
 * the words is contained in another file test.txt. The
 * result should be written in the file result.txt and the 
 * words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods. */

class FindsHowManyTimesWordsContain
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines(@"..\..\words.txt");
            int[] count = new int[words.Length];
            StreamReader reader = new StreamReader(@"..\..\test.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        count[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    }
                    line = reader.ReadLine();
                }
            }
            Array.Sort(count, words);
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0} - {1} times", words[i], count[i]);
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
