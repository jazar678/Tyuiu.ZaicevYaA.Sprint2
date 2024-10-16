using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZaicevYaA.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a < b | d == c ; 
            res[1] = d < b & a <= c ;
            res[2] = a-3 == d || c > b ;
            res[3] = d < b && a > c ;
            res[4] = !(res[1]);
            res[5] = (a == b) ^ (d <= c) ;

            return res; 
        }
    }
}
