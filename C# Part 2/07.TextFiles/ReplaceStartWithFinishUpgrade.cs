using System;
using System.IO;
using System.Text.RegularExpressions;

/* Modify the solution of the previous problem to replace only whole words (not substrings). */

class ReplaceStartWithFinish
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\input.txt");
        string line = string.Empty;
        using (read)
        {
            StreamWriter write = new StreamWriter(@"..\..\output.txt");
            using (write)
            {
                line = read.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\bstart\b", "finish");
                    write.WriteLine(line);
                    line = read.ReadLine();
                }
            }
        }
    }
}

