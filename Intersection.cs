namespace p03.IntersectionOfCircles
{
    using System;
    public class Program
    {
        class Circle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int R { get; set; }
        }

        static double CalcDistance(Circle a, Circle b)
        {
            int deltaX = Math.Abs(a.X - b.X);
            int deltaY = Math.Abs(a.Y - b.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static bool IntersectionOfCircles(Circle c1, Circle c2)
        {
            if (CalcDistance(c1, c2) <= c1.R + c2.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            Circle c1 = new Circle();
            string[] p1Values = Console.ReadLine().Split();
            c1.X = int.Parse(p1Values[0]);
            c1.Y = int.Parse(p1Values[1]);
            c1.R = int.Parse(p1Values[2]);

            Circle c2 = new Circle();
            string[] p2Values = Console.ReadLine().Split();
            c2.X = int.Parse(p2Values[0]);
            c2.Y = int.Parse(p2Values[1]);
            c2.R = int.Parse(p2Values[2]);

            if (IntersectionOfCircles(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
