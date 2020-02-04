using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    class PointFind
    {
        public List<Point> finder(List<Point> points, int x, int y, int size)
        {
            int geypotenuza = size*size*8;
            List<Point> outputList = new List<Point>();
            foreach (Point p in points)
            {
                int a = p.CoordX > x ? p.CoordX - x : x - p.CoordX;
                int b = p.CoordY > y ? p.CoordY - y : y - p.CoordY;

                if (a * a + b * b < geypotenuza)
                {
                    geypotenuza = a * a + b * b;
                    
                }
            }
            foreach (Point p in points)
            {
                int a = p.CoordX > x ? p.CoordX - x : x - p.CoordX;
                int b = p.CoordY > y ? p.CoordY - y : y - p.CoordY;

                if (a * a + b * b == geypotenuza)
                {
                    outputList.Add(new Point { CoordX = p.CoordX, CoordY = p.CoordY });
                }
            }
            return outputList;
        }
    }
}
