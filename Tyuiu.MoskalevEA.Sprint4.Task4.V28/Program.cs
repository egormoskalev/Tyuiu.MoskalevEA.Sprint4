using Tyuiu.MoskalevEA.Sprint4.Task4.V28.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task4.V28;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт  #4                                                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5];
        Console.WriteLine("Введите 25 целых чисел в диапазоне от 2 до 8:");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);

                array[i, j] = value;
            }
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j]);
                if (j < 4) Console.Write(", ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] modifiedArray = ds.Calculate(array);

        Console.WriteLine("Массив после замены чётных на 1:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(modifiedArray[i, j]);
                if (j < 4) Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}

