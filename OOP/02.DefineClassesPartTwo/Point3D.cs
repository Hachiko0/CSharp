using System;
using System.Collections.Generic;

namespace _02.DefineClassesPartTwo
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private static readonly Point3D startPoint3D;

        static Point3D()
        {
            startPoint3D = new Point3D();
        }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string result = string.Format("[{0}] [{1}] [{2}]", this.X, this.Y, this.Z);
            return result;
        }

        public static Point3D StartPoint3D
        {
            get
            {
                return startPoint3D;
            }
        }
        public double CalculateDistanceBeetweenPoints(Point3D second)
        {
            // - това е същото като статичния клас CalculateDistance - там обаче работим с класа и подабаваме като
            // параметър 2 точки, а тук работим с инстанция на една точка и на нея прилагаме метода като подаваме още 1 точка
            double distance = Math.Sqrt(Math.Pow(this.X - second.X, 2) + Math.Pow(this.Y - second.Y, 2) +
                Math.Pow(this.Z - second.Z, 2));
            return distance;
        }
    }
}
