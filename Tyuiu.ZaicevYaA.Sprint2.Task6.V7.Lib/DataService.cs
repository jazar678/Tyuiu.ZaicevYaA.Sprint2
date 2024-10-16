﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZaicevYaA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string res;
            switch (n)
            {
                case 1: res = "Январь"; break;
                case 2: res = "Февраль"; break;
                case 3: res = "Март"; break;
                case 4: res = "Апрель"; break;
                case 5: res = "Май"; break;
                case 6: res = "Июнь"; break;
                case 7: res = "Июль"; break;
                case 8: res = "Август"; break;
                case 9: res = "Сентябрь"; break;
                case 10: res = "Октябрь"; break;
                case 11: res = "Ноябрь"; break;
                case 12: res = "Декабрь"; break;
                default:
                    throw new ArgumentException($"Число должно быть от 1 до 12. Значение {n}");

            }

            return res;
        }
    }
}
