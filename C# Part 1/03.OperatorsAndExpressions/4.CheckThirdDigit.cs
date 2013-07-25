using System;

class CheckThirdDigit
{
    static void Main()
    {
        int number = 1732;
        int count = 0;
        int thirdDigit = 0;
        while (count != 3) // first option 
        {
            thirdDigit = number % 10;
            number = number / 10;
            count++;
        }
        if (thirdDigit == 7)
        {
            Console.WriteLine("{0} = 7 : True",thirdDigit);
        }
        else
        {
            Console.WriteLine("{0} = 7 : False", thirdDigit);
        }
        int number1 = 1732;
        int thirdDigit1 = (number1 / 100) % 10;
        if (thirdDigit1 == 7)
        {
            Console.WriteLine("{0} = 7 : True", thirdDigit1);
        }
        else
        {
            Console.WriteLine("{0} = 7 : False", thirdDigit1);
        }
    }
}

