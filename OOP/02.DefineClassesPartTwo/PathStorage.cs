using System;
using System.Collections.Generic;
using System.IO;

namespace _02.DefineClassesPartTwo
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < path.Count; i++)
                {
                    writer.WriteLine("{0} {1} {2}", path[i].X, path[i].Y, path[i].Z);
                }
            }
        }
        public static Path LoadPath(string fileName)
        {
            Path path = new Path();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        //1 2 3 coords[0] = 1, coords[1] = 2 and so on
                        string[] coords = line.Split();
                        Point3D point = new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
                        path.AddPoint(point);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("There is no such file with this name");
            }
            return path;
        }
    }
}
