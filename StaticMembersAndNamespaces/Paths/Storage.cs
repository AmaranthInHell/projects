using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Paths
{
    class Storage
    {
        public Storage()
        { }

        public static List<Path3D> LoadPaths()
        {
            List<Path3D> paths = new List<Path3D>();
            try
            {
                StreamReader reader = new StreamReader("paths.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Path3D path = new Path3D();
                        string[] pointsArr = line.Split(' ');
                        foreach (var point in pointsArr)
                        {
                            if (point != string.Empty)
                            {
                                int x = Convert.ToInt32(point[0] - 48);
                                int y = Convert.ToInt32(point[2] - 48);
                                int z = Convert.ToInt32(point[4] - 48);
                                path.AddPath(new Point3D(x, y, z));
                            }
                        }
                        paths.Add(path);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }

            return paths;
        }

        public static void SavePaths(Path3D path)
        {
            try
            {
                string point = "";
                StreamWriter writer = new StreamWriter("paths.txt");
                using (writer)
                {
                    for (int i = 0; i < path.Points.Count; i++)
                    {
                        point += path.Points[i] + " ";
                    }
                    writer.WriteLine(point);
                    point += Environment.NewLine;
                }
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
        }
    }
}
