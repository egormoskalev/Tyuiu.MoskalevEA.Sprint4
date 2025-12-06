using Tyuiu.MoskalevEA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task5.V9.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                {-4, -4, -1, -2, 2},
                {0, 2, -3, 4, 4},
                {-3, 2, -2, 1, 3},
                {4, 1, -4, 2, -4},
                {4, 1, 1, -1, 2}
            };

            int result = ds.Calculate(array);
            int expected = 33;

            Assert.AreEqual(expected, result);
        }
    }
}
