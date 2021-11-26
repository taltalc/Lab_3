using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины прямоугольника");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины прямоугольника");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x3 = 0;
            int y3 = 0;
            if (x1 != x2 || y1 != y2)
            {
                Console.WriteLine("Введите координаты третьей вершины прямоугольника");
                x3 = Convert.ToInt32(Console.ReadLine());
                y3 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Координаты введены неверно. Невозможно построить прямоугольник со сторонами, параллельными осям координат");
            }
            int x4;
            int y4;
            if (x3 == x1 && y3 == y2)
            {
                x4 = x2;
                y4 = y1;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }
            else if (x3 == x2 && y3 == y1)
            {
                x4 = x1;
                y4 = y2;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }
            else if (x3 != x1 && x3 != x2 && y3 == y1)
            {
                x4 = x3;
                y4 = y2;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }
            else if (x3 != x1 && x3 != x2 && y3 == y2)
            {
                x4 = x3;
                y4 = y1;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }
            else if (y3 != y1 && y3 != y2 && x3 == x1)
            {
                x4 = x2;
                y4 = y3;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }
            else if (y3 != y1 && y3 != y2 && x3 == x2)
            {
                x4 = x1;
                y4 = y3;
                Console.WriteLine("Координаты четвертой вершины прямоугольника {0}, {1}", x4, y4);
            }

            Console.ReadKey();


        }
    }
}
