using Tyuiu.ZaicevYaA.Sprint2.Task5.V15.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #2                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #15                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Введите знчение от 1 до 31");
            int num = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((num < 1) || (num > 31))
            {
                res = "Введено неверное значение";

            }
            else
            {
                res = "Этот день : " + ds.FindDayName(num);
            }
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}