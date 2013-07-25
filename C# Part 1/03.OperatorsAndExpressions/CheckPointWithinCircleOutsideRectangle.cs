using System;

class CheckPointWithinCircleOutsideRectangle
{
    static void Main()
    {
        double circleX = 1;
        double circleY = 1;
        double circleRadius = 3;
        double rectangleTop = 1;
        double rectangleLeft = -1;
        double rectangleWidth = 6;
        double rectangleHeight = 2;
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double pointInCircle = (pointX - circleX) * (pointX - circleX) + (pointY - circleY) * (pointY - circleY);
        bool isInCircle = (pointInCircle <= circleRadius * circleRadius); // check if point in in the circle
        bool isPointXOutsideRectangle = (pointX < rectangleTop && pointX > rectangleTop + rectangleWidth); // check if X is outside the rectangle
        bool isPointYOutsideRectangle = (pointY > rectangleLeft && pointY < rectangleLeft - rectangleHeight); // check if Y is outside the rectangle
        bool isOutsideRectangle = isPointXOutsideRectangle && isPointYOutsideRectangle; // check if the point is outside the rectangle
        if (isInCircle)
        {
            if (isPointXOutsideRectangle && isPointYOutsideRectangle)
            {
                Console.WriteLine("The point is in the circle and outside the rectangle");
            }
            else
            {
                Console.WriteLine("The point in in the circle and in the rectangle");
            }
        }
        else
        {
            if (isPointXOutsideRectangle && isPointYOutsideRectangle)
            {
                Console.WriteLine("The point is outside the circle and outside the rectangle");
            }
            else
            {
                Console.WriteLine("The point is outside the circle and in the rectangle");
            }
        }
    }
}

