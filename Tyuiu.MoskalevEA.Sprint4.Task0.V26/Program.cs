using Tyuiu.MoskalevEA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task0.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = {9, 3, 7, 1, 5, 3, 2, 1, 7};

        Console.Write("Массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int sumOdd = ds.GetSumOddArrEl(array);

        Console.WriteLine("Сумма нечётных элементов = " + sumOdd);

        Console.ReadKey();
    }
}
