//************************************************************/
//* Практическая работа №5                                   */
//* Выполнила: Метлева В.Д., группа 2ИСПД                    */
//* Задание: составить программу работы алгоритма ветвления  */
//************************************************************/



using System;
namespace практическая_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rose, tulips, difference;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Практическая работа № 5");
            Console.Write("Введите два цветка: \n");
            Console.Write("rose = ");
            rose = Convert.ToInt32(Console.ReadLine());
            Console.Write("tulips =");
            tulips = Convert.ToInt32(Console.ReadLine());
            
            rose = rose * 4 * 250;
            tulips = tulips * 4 * 120;

            if (rose > tulips)
            {
                difference = rose - tulips;
                Console.WriteLine($"У первой цветочницы выручка больше на : {difference} руб ");
            }
            else
            {
                 difference = tulips - rose;
                 Console.WriteLine($"У второй цветочницы выручка больше на : {difference} руб ");  
            }
            Console.ReadKey();
        }
    }
}
