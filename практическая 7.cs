//***************************************************************************/
//* Практическая работа №7                                                  */
//* Выполнила: Метлева В.Д., группа 2ИСПД                                   */
//* Задание:  cсоставить программу циклической структуры: цикл с параметром */
//***************************************************************************/



using System;
namespace практическая_7
{
    internal class Program
    {
        static void Main(string[] args) // точка ввода в программу
        {
            double n, sum, nomber; //объявление переменных
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Практическая работа № 7"); //заголовок консоли 
            Console.WriteLine("Здравствуйте.");
            Console.WriteLine("Введите кол-во n чисел: \n");
            Console.Write("n = ");
            n = Convert.ToDouble(Console.ReadLine());

            sum = 0;
            for ( double i = 1; i <= n; i++)
            {
                Console.Write($"Ввидите число {i}: ");
                nomber = Convert.ToDouble(Console.ReadLine());
                sum = sum + n;
            } 
                if (sum < 100)
                {
                    Console.WriteLine("число меньше 100, поэтому возводим куб : ");
                    sum = Math.Pow(sum, 3);
                    
                }
                else
                {
                    Console.WriteLine("число больше 100, поэтому вычисляем корень : ");
                    sum = Math.Sqrt(sum);
                    
                }
            
            Console.Write($"Ответ : {sum}");
            Console.ReadKey();//задержка экрана консоли
        }
    }
}
