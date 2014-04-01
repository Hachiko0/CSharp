using System;

namespace _02.DefineClassesPartTwo
{
    public static class CalculatePointsDistance
    {
        public static double CalculateDistanceBetweenPoints(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2) +
                Math.Pow(first.Z - second.Z, 2));
            return distance;
        }
    }
}
