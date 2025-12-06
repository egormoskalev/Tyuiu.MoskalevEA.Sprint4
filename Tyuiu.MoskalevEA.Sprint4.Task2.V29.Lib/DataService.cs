using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int sum = 1;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum *= element;
                }
            }
            return sum;
        }
    }
}