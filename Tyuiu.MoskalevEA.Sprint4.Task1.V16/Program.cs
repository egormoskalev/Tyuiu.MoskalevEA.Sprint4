using Tyuiu.MoskalevEA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task1.V16;
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

        int[] array = new int[13];
        Console.WriteLine("Введите 13 целых чисел в диапазоне от 3 до 8:");

        for (int i = 0; i < 13; i++)
        {
            Console.Write($"Элемент [{i + 1}]: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);


            if (value < 3 || value > 8)
            {
                Console.WriteLine("Вне задания");
                i--;
                continue;
            }

            array[i] = value;
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int sum = ds.Calculate(array);

        Console.WriteLine("Сумма чётных элементов = " + sum);

        Console.ReadKey();
    }
}

