using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Figure
    {
        Point[] points;

        public Figure(Point A, Point B, Point C)
        {
            points = new Point[3];
            points[0] = A;
            points[1] = B;
            points[2] = C;
        }

        public Figure(Point[] pts)
        {
            points = new Point[4];
            points[0] = pts[0];
            points[1] = pts[1];
            points[2] = pts[2];
            points[3] = pts[3];
        }

        public Figure(Point[] pts, Point e)
        {
            points = new Point[5];
            points[0] = pts[0];
            points[1] = pts[1];
            points[2] = pts[2];
            points[3] = pts[3];
            points[4] = e;
        }

        private double LengthOfSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0.0;
            switch (points.Length)
            {
                case 3: perimeter = LengthOfSide(points[0], points[1]) + LengthOfSide(points[1], points[2]) + LengthOfSide(points[2], points[0]); break;
                case 4: perimeter = LengthOfSide(points[0], points[1]) + LengthOfSide(points[1], points[2]) + LengthOfSide(points[2], points[3]) + LengthOfSide(points[3], points[0]); ; break;
                case 5: perimeter = LengthOfSide(points[0], points[1]) + LengthOfSide(points[1], points[2]) + LengthOfSide(points[2], points[3]) + LengthOfSide(points[3], points[4]) + LengthOfSide(points[4], points[0]); break;
                default: Console.WriteLine("Error"); break;
            }
            Console.WriteLine("Периметр: {0}", perimeter);
        }

        public string TypeOfFigure()
        {
            switch (points.Length)
            {
                case 3: return "Трикутник";
                case 4: return "Чотирикутник";
                case 5: return "П'ятикутник";
                default: return "Щось невідоме";
            }
        }
    }
}
