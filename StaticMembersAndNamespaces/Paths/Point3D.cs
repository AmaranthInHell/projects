using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    class Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Point3D Start
        {
            get { return start; }
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", X, Y, Z);
        }
    }
}
