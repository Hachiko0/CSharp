using System;

class NullVariables
{
    static void Main()
    {
        int? integerVariable = null;
        double? doubleVariable = null;
        Console.WriteLine(integerVariable); // prints nothing ( new line )
        Console.WriteLine(doubleVariable); // prints nothing( new line )
        Console.WriteLine(integerVariable + 1); // again print nothing
        Console.WriteLine(doubleVariable + 1.0); // again print nothing
        integerVariable = 5; // if we assign the null integer with a number then we can print it
        doubleVariable = 5.0;
        Console.WriteLine(integerVariable);
        Console.WriteLine(doubleVariable);
        
    }
}

