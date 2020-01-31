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
            int[][] dots = new int[10][];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(100);
                int y = random.Next(100);
                dots[i] = new int[2] { x, y };
                Console.WriteLine($"{x}, {y}");
            }
            int firstCoordinate = Convert.ToInt32(Console.ReadLine());
            int secondCoordinate = Convert.ToInt32(Console.ReadLine());
            int outcoordinate1=0;
            int outcoordinate2=0;
            int geypotenuza = 20000;
            foreach (int[] i in dots)
            {
                int x = i[0] > firstCoordinate ? i[0] - firstCoordinate : firstCoordinate - i[0];
                int y = i[1] > secondCoordinate ? i[1] - secondCoordinate : secondCoordinate - i[1];
                
                if (x * x + y * y < geypotenuza)
                {
                    geypotenuza = x * x + y * y;
                    outcoordinate1 = i[0];
                    outcoordinate2 = i[1];
                    
                }
            }
            Console.WriteLine($"Первая координата: { outcoordinate1}, Вторая координата: { outcoordinate2}") ;
            Console.ReadKey();
        }
    }
}
