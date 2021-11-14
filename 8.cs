using System;

namespace Zadanie8Lab3
{
    class Program
    {      
        static int[,] Minor(int[,] myArray, int n)
        {
            int [,] result = new int[myArray.GetLength(0) - 1, myArray.GetLength(0) - 1];
            for (int i = 1; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j == n) continue;
                    result[i - 1, j] = myArray[i, j];;
                }
            }
            return result;
        }
        static double DetMatrix(int[,] myArray)
        {
            if (myArray.Length == 1) return myArray[0, 0];
            if (myArray.Length == 4) return myArray[0, 0] * myArray[1, 1] - myArray[1, 0] * myArray[0, 1];
            else
            {
                double result = 0;
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    int[,] Mnr = Minor(myArray, i);
                    result += Math.Pow(-1, i) * myArray[0, i] * DetMatrix(Mnr);
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            int i, j;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите кол-во строк матрицы.");
                    i = int.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Такое число нельзя обработать");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                } break;              
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите кол-во столбцов матрицы.");
                    j = int.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Такое число нельзя обработать");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }
                break;
            }
            int[,]array = new int[i,j];
            Console.WriteLine(array.GetLength(0));
            Random rand = new Random();
            for (i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("");
                Console.WriteLine(new string('-', array.GetLength(0) * 5));
                for(j = 0; j < array.GetLength(0); j++)
                {
                    array[i, j] = rand.Next(-10,10);
                    Console.Write($"|{array[i, j], 3}|");
                }
            }
            Console.WriteLine("");
            Console.WriteLine(new string('-', array.GetLength(0) * 5));
            Console.WriteLine("");
            Console.WriteLine("Определитель матрицы: " + DetMatrix(array));
        }
    }
}
