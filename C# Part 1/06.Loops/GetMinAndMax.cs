using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetMinAndMax
{
    static void Main(string[] args)
    {
        //Read line, and split it by whitespace into an array of strings
        Console.WriteLine("Enter sequene of integer numbers leaving white space between each number: ");
        Console.WriteLine("Example : 1 15 32 30 100");
        string[] tokens = Console.ReadLine().Split();
        int max, min;
        max=min= Int32.Parse(tokens[0]);
        for (int i = 1; i < tokens.Length; i++)
        {
            int temp=Int32.Parse(tokens[i]);
            if (max < temp)
                max = temp;
            if (min > temp)
                min = temp;
        }
        Console.WriteLine("Max: "+max);
        Console.WriteLine("Min: "+min);
    }
}
