using Tyuiu.ZaicevYaA.Sprint2.Task6.V7.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task6.V7
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
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #7                                                    *");   
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Введите знчение от 1 до 12");
            int n = Convert.ToInt32(Console.ReadLine());
            string res;
           
            if ((n < 1) || (n> 12))
            {
                res = "Введено неверное значение";

            }
            else
            {
                res = "Это месяц :" + ds.FindMonthName(1990, n);
            }
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }

    }
}