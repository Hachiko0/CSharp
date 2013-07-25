using System;

class ApplyBonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = 0;
        bool check = int.TryParse(Console.ReadLine(), out score);
        switch (score)
        {
            case 1:
            case 2:
            case 3: score = score * 10;
                Console.WriteLine(score); break;
            case 4:
            case 5:
            case 6:
                score = score * 100;
                Console.WriteLine(score); break;
            case 7:
            case 8:
            case 9:
                score = score * 1000;
                Console.WriteLine(score); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}

