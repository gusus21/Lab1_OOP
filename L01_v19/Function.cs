using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Function
    {
        double x;
        double y;
        string[] data;
        double endX;

        public Function(double x_, double endX_)
        {
            x = x_;
            y = double.NaN;
            endX = endX_;
            data = FillArray();
        }

        public void ShowXYPairs()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine();
        }

        string[] FillArray()
        {
            string[] temp = new string[1];
            double step = double.Parse(Console.ReadLine());
            int k = 0;
            for (double i = x; i <= endX; i += step)
            {
                if (i > -1 && i <= 1)
                    y = Math.Sqrt(Math.Abs(1 - Math.Sqrt(Math.Abs(Math.Tan(1)))));
                else if (i < -10)
                    y = Math.Pow(Math.E, i) / Math.Log(2, 1 + Math.Tan(i));
                else
                    y = 0;
                if (y == 0)
                    temp[k] += $"{i}; ";
                else
                    temp[k] += $"{i}, {y}; ";
                k++;
                Array.Resize(ref temp, temp.Length + 1);
            }
            Array.Resize(ref temp, temp.Length - 1);
            return temp;
        }
    }
}
