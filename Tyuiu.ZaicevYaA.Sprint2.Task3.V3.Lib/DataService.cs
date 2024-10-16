using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZaicevYaA.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = Math.Round(Math.Pow(x * ((x + 1) / (x - 1)), x), 3);
            }
            else
            {
                if (x == 0)
                {
                   y = Math.Round((Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12)), 3);
                }
                else
                {
                    if ((-7 < x) && (x < 0))
                    {
                        y = Math.Round(Math.Pow(1 + (Math.Sqrt(x + 3)) / (Math.Pow(x, 2)), x), 3);
                    }
                    else
                    {
                        if (x < -7)
                        {
                            y = Math.Round(Math.Pow(x, 2) + 10 * x - ((1) / (x)), 3);
                        }
                    }
                }
            }
            return y;
        }
    }
}
