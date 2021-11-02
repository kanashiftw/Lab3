using System;

namespace Zadanie2Lab3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа выводит двумерный массив [7,7], а затем выводит его повернутым на 90° вправо");
            int i, j;
            int[,] array = new int[7, 7];
            Random random = new Random();
            Console.WriteLine("Массив:");
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    array [i, j] = random.Next(10);
                    Console.Write(array [i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Массив повернут вправо на 90°:");
            for (j = 0; j < 7; j++)
            {
                for (i = 6; i >= 0; i--)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
