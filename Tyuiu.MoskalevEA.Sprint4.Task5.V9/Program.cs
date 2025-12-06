using Tyuiu.MoskalevEA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rand = new Random();
            int[,] array = new int[5, 5];

            Console.WriteLine("Массив 5x5 (случайные числа от -4 до 4):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-4, 4);
                    Console.Write(array[i, j]);
                    if (j < 5) Console.Write(", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumPositive = ds.Calculate(array);

            Console.WriteLine("Сумма положительных элементов = " + sumPositive);

            Console.ReadKey();
        }
    }
}
