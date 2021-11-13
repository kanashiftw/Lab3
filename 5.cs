using System;

namespace Zadanie5Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i, j;
            Console.WriteLine("Первая матрица:");
            int[,] array1 = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    array1[i, j] = rand.Next(-10, 10);
                    Console.Write($"{array1[i, j],-3}|");
                    if (j == 4)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 20));
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Вторая матрица:");
            int[,] array2 = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    array2[i, j] = rand.Next(-10, 10);
                    Console.Write($"{array2[i, j],-3}|");
                    if (j == 4)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 20));
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Произведение матриц:");
            int[,] arrayproizv = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    arrayproizv[i, j] = array1[i, j] * array2[i, j];
                    Console.Write($"{arrayproizv[i, j],-3}|");
                    if (j == 4)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 20));
                    }
                }
            }
        }
    }
}
