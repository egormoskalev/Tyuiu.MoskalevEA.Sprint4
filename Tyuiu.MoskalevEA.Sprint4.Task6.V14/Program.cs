using Tyuiu.MoskalevEA.Sprint4.Task6.V14.Lib;

namespace Tyuiu.MoskalevEA.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            Console.Write("Исходный массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\"{array[i]}\"");
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(array);

            Console.Write("Элементы с длиной 3 символов: { ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"\"{result[i]}\"");
                if (i < result.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine();
            Console.WriteLine("Детальный анализ:");
            foreach (string element in array)
            {
                Console.WriteLine($"\"{element}\" - длина: {element.Length} символов");
            }

            Console.ReadLine();
        }
    }
}
