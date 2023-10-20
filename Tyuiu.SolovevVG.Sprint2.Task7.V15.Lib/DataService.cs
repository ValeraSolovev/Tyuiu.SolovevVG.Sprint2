using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.SolovevVG.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result = x * x + y * y >= 2 && x * x + y * y <= 4 && y >= 0;

            return result;
        }
    }
}
