using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    class Path3D
    {
        private List<Point3D> points = new List<Point3D>();

        public void AddPath(Point3D point)
        {
            points.Add(point);
        }

        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
