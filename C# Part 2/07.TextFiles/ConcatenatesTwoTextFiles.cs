using System;
using System.IO;
using System.Collections.Generic;

/* Write a program that concatenates two text files into another text file. */
// I wrote 2 different ways of this homework :
// 1st option - read line by line and write in in the final file
// 2nd option - read the whole file and write it in the final file

class ConcatenatesTwoTextFiles
{
    static void Main()
    {

        //StreamReader firstReader = new StreamReader(@"..\..\firstFile.txt");
        //using (firstReader)
        //{
        //    string line = firstReader.ReadLine();
        //    StreamReader secondReader = new StreamReader(@"..\..\secondFile.txt");
        //    using (secondReader)
        //    {
        //        StreamWriter writer = writer = new StreamWriter(@"..\..\lastFile.txt");
        //        using (writer)
        //        {
        //            while (line != null)
        //            {
        //                writer.WriteLine(line);
        //                line = firstReader.ReadLine();
        //            }
        //            line = secondReader.ReadLine();
        //            while (line != null)
        //            {
        //                writer.WriteLine(line);
        //                line = firstReader.ReadLine();
        //            }
        //        }
        //    }
        //}
        StreamReader firstReader = new StreamReader(@"..\..\firstFile.txt");
        using (firstReader)
        {
            string firstFile = firstReader.ReadToEnd();
            StreamReader secondReader = new StreamReader(@"..\..\secondFile.txt");
            using (secondReader)
            {
                string secondFile = secondReader.ReadToEnd();
                StreamWriter writer = new StreamWriter(@"..\..\lastFile.txt");
                using (writer)
                {
                    writer.WriteLine(firstFile);
                    writer.WriteLine(secondFile);
                }
            }
        }
    }
}

