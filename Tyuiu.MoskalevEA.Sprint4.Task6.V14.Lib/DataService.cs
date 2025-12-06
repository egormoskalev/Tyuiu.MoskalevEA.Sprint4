using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevEA.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] filtered = Array.FindAll(array, s => s.Length == 3);
            return filtered.Length;
        }
    }
}
