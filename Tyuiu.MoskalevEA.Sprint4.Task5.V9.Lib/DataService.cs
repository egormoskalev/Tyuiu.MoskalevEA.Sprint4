using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        sum += array[i, j];
                }
            }
            return sum;
        }
    }
}
