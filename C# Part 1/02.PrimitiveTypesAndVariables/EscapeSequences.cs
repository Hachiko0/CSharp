using System;

class EscapeSequences
{
    static void Main()
    {
        string firstEscape = "The \"use\" of quotations causes difficulties";
        string secondEscape = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(firstEscape);
        Console.WriteLine(secondEscape);
    }
}

