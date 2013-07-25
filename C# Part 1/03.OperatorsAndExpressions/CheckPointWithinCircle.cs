using System;

class CheckPointWithinCircle
{
    static void Main()
    {
        double circleX = 0;
        double circleY = 0;
        double circleRadius = 5;
        double pointX = int.Parse(Console.ReadLine());
        double pointY = int.Parse(Console.ReadLine());

        //(x-circle_x)^2 + (y - circle_y)^2 < ircleRadius^2 - this is the formula I use to check whether a point in in circle
        double isInside = (pointX - circleX) * (pointX - circleX) + (pointY - circleY) * (pointY - circleY);
        if (isInside < circleRadius * circleRadius)
        {
            Console.WriteLine("The point {0},{1} is inside the circle", pointX, pointY);
        }
        else if (isInside == circleRadius * circleRadius)
        {
            Console.WriteLine("The point {0},{1} is on the circle", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The point {0},{1} is outside the circle", pointX, pointY);
        }
    }
}

