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
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Практическая работа № 5");
            Console.Write("Введите два цветка: \n");
            Console.Write("розы = ");
            try
            {
                rose = Convert.ToInt32(Console.ReadLine());
                Console.Write("тюльпаны = ");
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
                        switch (rose < tulips)
                        {
                            case true:
                                difference = tulips - rose;
                                Console.WriteLine($"У двух цветочниц одинаковая выручка {difference} руб ");
                                break;
                            case false:
                                difference = tulips = rose;
                                Console.WriteLine($"У двух цветочниц одинаковая выручка {difference} руб ");
                                break;
                        }
                        break;
                }
            }
            catch (FormatException fex) //не дает ввести букву
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ошибка: {fex.Message}");
            }
            catch (OverflowException oex) //не дает ввести большое число
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ошибка: {oex.Message}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}