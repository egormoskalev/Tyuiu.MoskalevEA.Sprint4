using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.MoskalevEA.Sprint4.Task0.V26.Lib
{
    public class DataService : ISprint4Task0V26
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
