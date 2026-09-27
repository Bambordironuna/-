//****************************************************************************************************************/
//* Практическая работа №6                                                                                       */
//* Выполнила: Метлева В.Д., группа 2ИСПД                                                                        */
//* Задание: составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения  */
//****************************************************************************************************************/



using System;
namespace практическая_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rose, tulips, difference;
            Console.Clear(); //очистка консоли
            Console.BackgroundColor = ConsoleColor.Cyan; //заливка шрифта
            Console.ForegroundColor = ConsoleColor.DarkBlue; //текст шрифта
            Console.WriteLine("Практическая работа № 5");
            Console.Write("Введите два цветка: \n");
            Console.Write("rose = ");
            rose = Convert.ToInt32(Console.ReadLine());
            Console.Write("tulips =");
            tulips = Convert.ToInt32(Console.ReadLine());

            rose = rose * 4 * 250;
            tulips = tulips * 4 * 120;

            switch (rose > tulips)
            {
                case true:
                difference = rose - tulips;
                Console.WriteLine($"У первой цветочницы выручка больше на : {difference} руб ");
                    break;
            
                case false:
                difference = tulips - rose;
                Console.WriteLine($"У второй цветочницы выручка больше на : {difference} руб ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
