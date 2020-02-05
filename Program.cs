using System;
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
            Console.WriteLine("First coordinate");

            int firstCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Coordinate");
            int secondCoordinate = Convert.ToInt32(Console.ReadLine());


            var list = new PointList();
            list.PointListFill(size, quantity);
            var finder = new PointFind();
            foreach (Point p in finder.finder(list.PointListFill(size, quantity), firstCoordinate, secondCoordinate, size))
            {
                Console.WriteLine($" {p.CoordX} {p.CoordY} ");
            }
            Console.ReadKey();
        }
    }
}
