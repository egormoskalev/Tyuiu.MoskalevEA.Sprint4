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

        int[] array = new int[14];
        Console.WriteLine("Введите 14 целых чисел в диапазоне от 3 до 8:");

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

        Console.WriteLine("Сумма нечётных элементов = " + sum);

        Console.ReadKey();
    }
}
