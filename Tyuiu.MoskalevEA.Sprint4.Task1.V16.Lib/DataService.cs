using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        
        public int Calculate(int[] array)
        {
            int sum = 1;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    sum *= element;
                }
            }
            return sum;
        }
    }

}

