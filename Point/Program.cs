using System;
using System.Collections.Generic;
using System.Linq;

namespace Point
{
    public struct Point
    {
        public int X { get; }

        public Point(int x)
        {
            X = x;
        }

        public Point IncX()
        {
            return new Point(X + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>(Enumerable.Range(1, 10).Select(p => new Point(p)));
            for (var i = 0; i < points.Count; i++)
            {
                points[i] = points[i].IncX();
            }
            foreach (var p in points)
            {
                Console.WriteLine(p.X);
            }
            Console.ReadKey();
        }
    }
}
