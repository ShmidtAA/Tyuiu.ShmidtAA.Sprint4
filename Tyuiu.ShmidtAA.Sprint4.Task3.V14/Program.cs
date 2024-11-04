﻿using Tyuiu.ShmidtAA.Sprint4.Task3.V14.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7. Найдите максимальный     *");
            Console.WriteLine("* элемент в четвертой строке массива.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    Массив:                                                              *");
            Console.WriteLine("*    {3, 2, 3, 3, 5},                                                     *");
            Console.WriteLine("*    {2, 3, 3, 7, 3},                                                     *");
            Console.WriteLine("*    {7, 5, 2, 7, 3},                                                     *");
            Console.WriteLine("*    {4, 2, 7, 5, 2},                                                     *");
            Console.WriteLine("*    {3, 5, 4, 2, 6}                                                      *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[5, 5]
            {
            {3, 2, 3, 3, 5 },
            {2, 3, 3, 7, 3 },
            {7, 5, 2, 7, 3 },
            {4, 2, 7, 5, 2 },
            {3, 5, 4, 2, 6 }

            };
            DataService ds = new DataService();
            Console.WriteLine($"* РЕЗУЛЬТАТ:   {ds.Calculate(array)}                                                          *");
            

         
            Console.WriteLine("***************************************************************************");

            
        }
    }
}
