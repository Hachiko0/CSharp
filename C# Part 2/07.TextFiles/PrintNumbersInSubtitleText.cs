using System;
using System.IO;
using System.Collections.Generic;

/* Not part of the homework, just practicing streams and string methods :) */

class PrintNumbersInSubtitleText
{
    public static List<int> numbers = new List<int>();
    static int FindFramesInSubtitle(int start, string str)
    {
        int firstIndex = str.IndexOf('{', start);
        int secondIndex = str.IndexOf('}', firstIndex + 1);
        if (firstIndex == -1 || secondIndex == -1) return 0;
        int between = secondIndex - firstIndex - 1;
        int number = int.Parse(str.Substring(firstIndex + 1, between));
        numbers.Add(number);
        return secondIndex;
    }
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\sub.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                int start = 0;
                for (int i = 0; i < 2; i++)
                {
                    start = FindFramesInSubtitle(start, line);
                }
                line = reader.ReadLine();
            }
        }
        for (int i = 0; i < numbers.Count; i = i + 2)
        {
            Console.WriteLine(" {{{0}}}{{{1}}}",numbers[i],numbers[i + 1]);
        }
    }
}

