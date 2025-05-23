﻿namespace ThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new(2, 3);
            Point secondPoint = new(-4, 0);
            firstPoint.GetCoordinates();
            secondPoint.GetCoordinates();
        }
    }

    internal class Point
    {
        internal int X { get; set; }

        internal int Y { get; set; }

        internal Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        internal Point() : this(0, 0) { }

        internal void GetCoordinates()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

    // In my class the point is mutable, so I can change the coordinates of the point.
}
