using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    class PointList
    {
        public List<Point> points = new List<Point>();
        Random rnd = new Random();
        public void PointListFill(int max, int quantity)
        {
            
            for (int i = 0; i < quantity; i++)
            {
                points.Add(new Point { CoordX = rnd.Next(-max, max), CoordY = rnd.Next(-max, max) });
            }
        }

    }
}
