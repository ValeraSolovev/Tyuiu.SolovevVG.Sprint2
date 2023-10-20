using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.SolovevVG.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == d) | (b != c);
            res[1] = (a > b) & (a == d);
            res[2] = (a >= c) || (b <= d);
            res[3] = (b == c) && (b < c);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }   
    }       
}           
            
            