using Tyuiu.ShmidtAA.Sprint4.Task7.V6.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"458963214789\".                       *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*    \"458963214789\"                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string nums = "458963214789";
            int rows = 3;
            int cols = 4;
            int[,] matrix = new int[rows, cols];
            int res = ds.Calculate(rows, cols, nums);
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{nums[index++]}\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine(res);
        }
    }
}
