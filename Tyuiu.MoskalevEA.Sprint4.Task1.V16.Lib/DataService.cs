using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
             int sum = 0;
             foreach (int i in array)
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
