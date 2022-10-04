﻿using System;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;
        private double area, perimetr;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            AreaCalculator();
            PerimeterCalculator();
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Write("Введіть першу сторону прямокутника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть другу сторону прямокутника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle calculator = new Rectangle(side1, side2);
            Console.WriteLine("Площадь: " + calculator.Area + "\nПериметр: " + calculator.Perimeter);
            Console.ReadKey();
        }
    }
}
