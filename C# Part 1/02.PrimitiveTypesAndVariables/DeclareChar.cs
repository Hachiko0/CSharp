using System;

class DeclareChar
{
    static void Main()
    {
        char ch = '\u0048';
        Console.WriteLine(ch == (char)72);
        Console.WriteLine((char)0x48); // first option - 0x means hecadeximal number
        Console.WriteLine((char)72);  // second option - 72 refers to UNICODE table
        Console.WriteLine(ch);       // third option - literal
    }
}
