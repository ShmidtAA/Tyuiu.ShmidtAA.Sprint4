using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShmidtAA.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 2 || array[i] > 9)
                {
                    throw new ArgumentOutOfRangeException(nameof(array), array[i], "Значение вышло за диапазон значение от 2 до 9");
                }
                else if (array[i] % 2 == 0) 
                {
                    res *= array[i];
                }

            }
        return res;
        }

    }
}
