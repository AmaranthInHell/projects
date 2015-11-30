using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Paths;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D one = new Point3D(1, 2, 3);
            Point3D two = new Point3D(4, 5, 6);

            Console.WriteLine(DistanceCalculator.CalculateDistance(one, two));

            Path3D path1 = new Path3D();
            Path3D path2 = new Path3D();

           
            path2.AddPath(two);
            path2.AddPath(one);
            path1.AddPath(one);
            path1.AddPath(two);

            Storage.SavePaths(path1);
            Storage.SavePaths(path2);

            for (int i = 0; i < Storage.LoadPaths().Count; i++)
            {
                Console.Write("Path{0}: ", i + 1);
                for (int j = 0; j < Storage.LoadPaths()[i].Points.Count; j++)
                {
                    Console.Write(Storage.LoadPaths()[i].Points[j].ToString());
                    if (j < Storage.LoadPaths()[i].Points.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
