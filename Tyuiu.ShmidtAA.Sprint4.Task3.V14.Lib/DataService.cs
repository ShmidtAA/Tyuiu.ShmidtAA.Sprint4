using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShmidtAA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)

        /* 

        {3, 2, 3, 3, 5 }, |0
        {2, 3, 3, 7, 3 }, |1
        {7, 5, 2, 7, 3 }, |2
        {4, 2, 7, 5, 2 }, |*3
        {3, 5, 4, 2, 6 }  |4
         
         */
        {
            int temp =  array[3,0];
            for (int i = 1; i < array.GetLength(1); i++ )
            {
                //[ROW][COL]
                
                if (temp < array[3,i] )
                {
                    temp = array[3, i]; 
                }

            }
            return temp;
        }
    }
}
