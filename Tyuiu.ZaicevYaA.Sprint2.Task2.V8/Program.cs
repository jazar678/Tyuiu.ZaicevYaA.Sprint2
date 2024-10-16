using Tyuiu.ZaicevYaA.Sprint2.Task2.V8.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #2                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #8                                                    *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Введите значение X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            if (res)
            {
                Console.WriteLine("Область находиться в не заштрихованной области");
            }
            else
            {
                Console.WriteLine("Область находиться в заштрихованной области");
            }
                Console.ReadKey();
        }
    }
}