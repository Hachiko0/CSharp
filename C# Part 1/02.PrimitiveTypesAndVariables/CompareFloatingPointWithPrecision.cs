using System;

class Program
{
    static void Main()
    {
        float firstVariable = 5.0000154f;
       float secondVariable = 5.0000153f;
        if (Math.Abs(firstVariable - secondVariable) < 0.000001)
        {
            Console.WriteLine("{0} = {1}", firstVariable, secondVariable);
        }
        else
        {
            Console.WriteLine("{0} != {1}",firstVariable,secondVariable);
        }
    }
}

