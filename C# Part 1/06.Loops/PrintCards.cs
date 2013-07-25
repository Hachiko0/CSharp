using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintCards
{
    static void Main(string[] args)
    {
        Console.BufferHeight = 100;
        //Console.BufferWidth = 300;
        char spades = '\u2663';
        char hearts = '\u2665';
        char diamonds = '\u2666';
        char clubs = '\u2660';
        int baseX = 1;
        int baseY = 1;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cards ordered by card colour: ");
        byCardColour(baseX, baseY, spades, hearts, diamonds, clubs);
        baseY = 18;
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cards ordered by card type: ");
        byCardType(spades, hearts, diamonds, clubs, ref baseX, ref baseY);
    }

    private static void byCardType(char spades, char hearts, char diamonds, char clubs, ref int baseX, ref int baseY)
    {
        int x = baseX;
        int y = baseY;
        for (int j = 1; j <= 13; j++)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.ForegroundColor = ConsoleColor.White;

                switch (j)
                {
                    case 1:
                        Console.Write("Ace ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    case 10:
                        Console.Write("Ten ");
                        break;
                    case 11:
                        Console.Write("Jack ");
                        break;
                    case 12:
                        Console.Write("Queen ");
                        break;
                    case 13:
                        Console.Write("King ");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                switch (i)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(spades.ToString() + " ");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(hearts.ToString() + " ");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(diamonds.ToString() + " ");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(clubs.ToString() + " ");
                        break;
                    default:
                        Console.Write("Error");
                        break;
                }
                Console.WriteLine();
            }
            if (x >= Console.WindowWidth - 10)
            {
                baseX = 1;
                x = baseX;
                baseY += 5;
                y = baseY;
            }
            else
            {
                x += 10;
                y = baseY;
            }

        }
    }

    private static void byCardColour(int baseX, int baseY, char spades, char hearts, char diamonds, char clubs)
    {
        int x = baseX;
        int y = baseY;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                Console.SetCursorPosition(x, j);
                switch (i)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(spades.ToString() + " ");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(hearts.ToString() + " ");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(diamonds.ToString() + " ");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(clubs.ToString() + " ");
                        break;
                    default:
                        Console.Write("Error");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;

                switch (j)
                {
                    case 1:
                        Console.Write("Ace ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    case 10:
                        Console.Write("Ten ");
                        break;
                    case 11:
                        Console.Write("Jack ");
                        break;
                    case 12:
                        Console.Write("Queen ");
                        break;
                    case 13:
                        Console.Write("King ");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine();
            }
            x += 20;
            Console.WriteLine();
        }
    }
}
