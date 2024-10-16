using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZaicevYaA.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string res;
            if ((1 <= k) && (k <= 365)) ;
            {
                switch (k % 7)
                {
                    case 1:
                        res = "Понедельник";
                        break;
                    case 2:
                        res = "Вторник";
                        break;
                    case 3:
                        res = "Среда";
                        break;
                    case 4:
                        res = "Четверг";
                        break;
                    case 5:
                        res = "Пятница";
                        break;
                    case 6:
                        res = "Суббота";
                        break;
                    case 7:
                        res = "Воскресенье";
                        break;

                    default:
                        throw new ArgumentException($"Число должно быть от 1 до 31. Значение {k}");
                }
            }

            return res;
        }



    }
}