using System;
using System.Text;

namespace ThirdTask
{
    class Point
    {
        private int x, y;
        private string TitlePoint;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string NameTitle
        {
            get { return TitlePoint; }
        }
        public Point() { }
        public Point(int x, int y, string c)
        {
            this.x = x;
            this.y = y;
            this.TitlePoint = c;
        }
    }

    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public Figure() { }
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }
        public void PerimeterCalculator()
        {
            if (E != null)
            {
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.WriteLine("Периметр п'ятикутника = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) + LengthSide(D, E) + LengthSide(E, A)));
            }
            else if (D != null)
            {
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.WriteLine("Периметр чотирикутника = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A)));
            }
            else
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.WriteLine("Периметр трикутника = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "point1");
            Point B = new Point(1, 0, "point2");
            Point C = new Point(1, 1, "point3");
            Point D = new Point(0, 1, "point4");
            Figure figure = new Figure(A, B, C, D);
            figure.PerimeterCalculator();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
