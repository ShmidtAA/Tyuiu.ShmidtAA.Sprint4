using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShmidtAA.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            foreach(int number  in matrix)
            {
                if (number % 2 == 0)
                {
                    count += number;
                }

            }
            return count;
        }
    }
}
