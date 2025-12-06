using Tyuiu.MoskalevEA.Sprint4.Task3.V22.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task3.V22;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт  #4                                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = {
                {4, 4, 7, 8, 9},
                {9, 5, 9, 7, 8},
                {7, 4, 9, 4, 6},
                {4, 4, 7, 4, 4},
                {4, 5, 8, 6, 7}
            };


        Console.WriteLine("Массив 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j]);
                if (j < 5) Console.Write(", ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int maxInThirdColums = ds.Calculate(array);

        Console.WriteLine("Max в первой строке = " + maxInThirdColums);

        Console.ReadKey();
    }
}
