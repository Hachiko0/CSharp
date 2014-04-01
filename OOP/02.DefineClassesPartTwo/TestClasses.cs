using System;
using System.Collections.Generic;
namespace _02.DefineClassesPartTwo
{
    public class TestClasses
    {
        public static void Main()
        {
            //var proba = new { Age = 5, Y = 6, Name = "ivan" };
            //var names = new[] { new { a = 5, b = 6 }, new { a = 1, b = 2 } };
            //var eho = new Point3D[] { new Point3D { X = 1, Y = 2 } };

            List<int> krasi = new List<int>();
            krasi.Add(4);
            krasi.Add(3);
            List<int> found = krasi.FindAll(x => (x - 1) == 2);
            Point3D point = Point3D.StartPoint3D;
            Point3D point1 = new Point3D(4, 3, 2);
            Path path = new Path();
            path.AddPoint(point);
            path.AddPoint(point1);
            Console.WriteLine(path[4, 3, 2]);
            int[] arr = new int[4];
            path.AddPoint(point1);
            Console.WriteLine(path[1].X);
            PathStorage.SavePath(path, @"../SavePath.txt");
            Path eho = PathStorage.LoadPath(@"../PathLoad.txt");
            //GenericList<int> list = new GenericList<int>(20);
            //for (int i = 0; i < 40; i++)
            //{
            //    list.Add(i + 1);
            //}
            //list.InsertAt(0, 666);
            //list.Add(41);
            //list.RemoveAt(20);
            //list.Add(155);
            //list.InsertAt(1, 222);
            //Console.WriteLine(list.ToString());
            //Console.WriteLine(list.Min());
            //Console.WriteLine(list.Max());
            //list.ClearList();

            //Matrix<int> first = new Matrix<int>(3, 3);
            //int one = 1;
            //for (int i = 0; i < first.Rows; i++)
            //{
            //    for (int j = 0; j < first.Cols; j++)
            //    {
            //        first[i, j] = one;
            //    }
            //}
            //if (first)
            //{
            //    Console.WriteLine("There is at least 1 zero element");
            //}
            //else
            //{
            //    Console.WriteLine("There aren't any zero elements");
            //}
            //first[0, 0] = 0;
            //int two = 2;
            //Matrix<int> second = new Matrix<int>(3, 3);
            //for (int i = 0; i < first.Rows; i++)
            //{
            //    for (int j = 0; j < first.Cols; j++)
            //    {
            //        second[i, j] = two;
            //    }
            //}
            //Matrix<int> result = first + second;
        }
    }
}
