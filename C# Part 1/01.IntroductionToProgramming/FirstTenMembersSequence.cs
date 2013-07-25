using System;

class FirstTenMembersSequence
{
    static void Main()
    {
        for (int i = 2,j = -3; i <= 10; i = i + 2,j = j - 2) // first option
        {
            Console.Write("{0} {1} ",i,j);
        }
        Console.WriteLine();

        for (int i = 2; i <= 11; i++) // second option
        {
            if (i % 2 == 0)
            {
                Console.Write("{0} ",i);
            }
            else
            {
                Console.Write("{0} ", i * -1);
            }
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i = i + 2) // third option
        {
            Console.Write("{0} {1} ", i + 2, -i - 3);
        }
    }
}
