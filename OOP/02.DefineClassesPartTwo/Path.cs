using System;
using System.Collections.Generic;

namespace _02.DefineClassesPartTwo
{
    public class Path
    {
        private List<Point3D> listOfPoints = new List<Point3D>();

        public void AddPoint(Point3D poind3D)
        {
            this.listOfPoints.Add(poind3D);
        }

        public void ClearPath()
        {
            this.listOfPoints.Clear();
        }
        public Point3D this[int number]
        {
            get
            {
                if (number >= 0 && number < this.Count)
                {
                    return listOfPoints[number];
                }
                throw new IndexOutOfRangeException("index out of range");
            }
        }

        public int Count
        {
            get
            {
                return listOfPoints.Count;
            }
        }
        public Point3D this[int x, int y, int z]
        {
            get
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this.listOfPoints[i].X == x && this.listOfPoints[i].Y == y && this.listOfPoints[i].Z == z)
                    {
                        return this.listOfPoints[i];
                    }
                }
                throw new ArgumentException("Wrong argument");
            }
        }
        //public List<Point3D> ListOfPoints
        //{
        //    get
        //    {
        //        return this.listOfPoints;
        //    }
        //}
    }
}
