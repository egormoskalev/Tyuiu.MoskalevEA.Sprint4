using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                        array[i, j] = 1;
                }
            }

            return array;
        }

        int ISprint4Task3V28.Calculate(int[,] array)
        {
            throw new NotImplementedException();
        }
    }
}
