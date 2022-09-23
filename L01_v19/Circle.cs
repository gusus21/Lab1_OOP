using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Circle
    {
        double x, y, r;

        public Circle(double x_, double y_, double r_)
        {
            x = x_;
            y = y_;
            r = r_;
        }

        private int GetQuadrant()
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else if (x > 0 && y < 0)
                return 4;
            else return 0;
        }
        private double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        private double PerimeterCalc()
        {
            return 2 * 3.14 * r;
        }

        public int Quadrant => GetQuadrant();
        public double Area => GetArea();
        public double Perimeter => PerimeterCalc();
    }
}
