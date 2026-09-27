using System;
using System.Net.NetworkInformation;

namespace практическая_работа__4
{
    internal class Program
    {
        static void Main(string[] args) //точка ввода в программу
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Практическая работа 4"; //заголовок консоли

            double a, b, c, S; //объявление переменных
            double v1, v2, v3, v4, v5, v6, v7;

            Console.WriteLine("Здравствуйте.");
            Console.Write("Ввeдите a = "); // ввод исходных данных 
            a = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Ввeдите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввeдите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            // расчет значения выражения 
            v1 = Math.Pow(10, 1.0 / 3); // возведение в степень
            v2 = Math.Pow(a, 1.0 / (3.0 * Math.Abs(b))); // возведение в степень
            v3 = Math.Pow(b, 4);// возведение в степень
            v4 = Math.Pow(c, 1.0 / 2.0);// возведение в степень
            v5 = v1 + (v2 * v3 * v4);
            v6 = Math.Log10(v5);
            v7 = Math.Exp(a * b * Math.Pow(c, -2));


            S = v6 + v7;

            //вывод результата на экран
            Console.WriteLine("Результат : S = {0 : #.###}", S);
            Console.ReadKey();//задержка экрана консоли
        }
    }
}
