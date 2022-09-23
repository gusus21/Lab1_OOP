using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Point
    {
        int x; 
        int y;
        string name;

        public int X => x;
        public int Y => y;

        public Point(int x_, int y_, string name_)
        {
            x = x_;
            y = y_;
            name = name_;
        }
    }
}
