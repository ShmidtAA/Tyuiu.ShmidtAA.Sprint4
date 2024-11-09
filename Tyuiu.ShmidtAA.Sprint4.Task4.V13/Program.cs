using Tyuiu.ShmidtAA.Sprint4.Task4.V13.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Найдите сумму четных     *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    Массив для теста:                                                    *");
            Console.WriteLine("*    {6, 3, 5, 7, 5},                                                     *");
            Console.WriteLine("*    {3, 5, 7, 4, 5},                                                     *");
            Console.WriteLine("*    {5, 6, 4, 5, 4},                                                     *");
            Console.WriteLine("*    {7, 4, 7, 3, 3},                                                     *");
            Console.WriteLine("*    {4, 6, 5, 5, 6}                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Введите число:");
                    int num = Convert.ToInt32(Console.ReadLine()); 
                    if (num >= 3 && num <= 7)
                    {
                        matrix[i, j] = num;
                    }
                    else
                    {
                        Console.WriteLine("неправильный ввод");
                    }
                    
                }

            }
            DataService ds = new DataService();

            Console.WriteLine("ответ " +  ds.Calculate(matrix)); 

        }
    }
}
