using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.SolovevVG.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x * (Math.Pow((x + 1) / (x - 1), x));
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 3);
            }
            else if (x < -27 && x < 2)
            {
                res = Math.Pow(3 + (1 / Math.Pow(x, 2)), x);
            }
             else if (x < -27)
            {
                res = x + 10 * x - (1 / Math.Pow(x, 2));
            }

            return Math.Round(res, 3);
        }
    }
}
