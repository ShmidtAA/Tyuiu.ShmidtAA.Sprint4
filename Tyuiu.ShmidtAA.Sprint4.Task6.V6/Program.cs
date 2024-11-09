using Tyuiu.ShmidtAA.Sprint4.Task6.V6.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Борис\", \"Анна\", \"Михаил\", \"Ирина\", \"Сергей\", *");
            Console.WriteLine("* \"Татьяна\", \"Олег\"], используя класс Array, выведите элементы массива,     *");
            Console.WriteLine("* длина которых равна 5 символам.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*    [\"Борис\", \"Анна\", \"Михаил\", \"Ирина\", \"Сергей\", \"Татьяна\", \"Олег\"]      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string[] array = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            foreach (string item in ds.Calculate(array))
            {
                Console.WriteLine(item);
            }

        }
    }
}
