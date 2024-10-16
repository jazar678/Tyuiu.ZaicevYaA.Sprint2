using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZaicevYaA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string res;
            switch (n)
            {
                case 1: res = "январь"; break;
                case 3: res = "февраль"; break;
                case 2: res = "март"; break;
                case 4: res = "апрель"; break;
                case 5: res = "май"; break;
                case 6: res = "июнь"; break;
                case 7: res = "июль"; break;
                case 8: res = "август"; break;
                case 9: res = "сентябрь"; break;
                case 10: res = "октябрь"; break;
                case 11: res = "ноябрь"; break;
                case 12: res = "декабрь"; break;
                default:
                    throw new ArgumentException($"Число должно быть от 1 до 12. Значение {n}");

            }

            return res;
        }
    }
}
