using System;

class ShowSignOfProduct
{
    static void Main()
    {
        int count = 0;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0) // if all are 0 the sign is not + neither -
        {
            Console.WriteLine("The result is 0");
        }
        else
        {
            if (firstNumber < 0)
            {
                count++;
            }
            if (secondNumber < 0)
            {
                count++;
            }
            if (thirdNumber < 0)
            {
                count++;
            }
        }
        if (count == 1 || count == 3) // (+) * (+) * (-) = (-) or (-) * (-) * (-) = (-)
        {
            Console.WriteLine("The sign of {0},{1} and {2} is -", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("The sign of {0},{1} and {2} is +", firstNumber, secondNumber, thirdNumber);
        }
    }
}
