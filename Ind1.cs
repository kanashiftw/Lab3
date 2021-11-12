using System;

namespace Ind1Lab3
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица:");
            int[,] array = new int[9, 9];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 9; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(new String('-', 45));
                for (j = 0; j < 9; j++)
                {
                    array[i, j] = rand.Next(-10,10);
                    Console.Write($"|{array[i,j],3}|");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(new String('-', 45));
            Console.WriteLine("Матрица зеркальная относительно главной диагонали:");
            for (i = 0; i < 9; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(new String('-', 45));
                for (j = 0; j < 9; j++)
                {
                    Console.Write($"|{array[j, i],3}|");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(new String('-', 45));
        }
    }
}
