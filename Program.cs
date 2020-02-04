using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Size");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int firstCoordinate = Convert.ToInt32(Console.ReadLine());
            int secondCoordinate = Convert.ToInt32(Console.ReadLine());


            PointList list = new PointList();
            list.PointListFill(size, quantity);
            PointFind finder = new PointFind();
            foreach (Point p in finder.finder(list.points, firstCoordinate, secondCoordinate, size))
            {
                Console.WriteLine($" {p.CoordX} {p.CoordY} ");
            }     
            Console.ReadKey();
        }
    }
}
