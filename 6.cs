using System;

namespace Zadanie6Lab3
{
    class Program
    {
        static int sumRecursive(int[] myArray,int i = 0)
        {
            if (i >= myArray.Length) return 0;
            else return myArray[i] + sumRecursive(myArray, i + 1);
        }      
        static int sumIterative(int[] myArray, int i = 0)
        {
            int sum = 0;
            for (i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        static int minRecursive(int[] myArray, int i = 0)
        {
            if (i + 1 == myArray.Length) return myArray[i];
        else return Math.Min(myArray[i], minRecursive(myArray, ++i));
        }
        static int minIterative(int[] myArray, int min, int i = 0)
        {
            for (i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[12];
            Random rand = new Random();
            Console.Write("Массив: ");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Сумма рекурсивно: " + sumRecursive(array));
            Console.WriteLine("Сумма итеративно: " + sumIterative(array));
            Console.WriteLine("Минимальное рекурсивно: " + minRecursive(array));
            Console.WriteLine("Минимальное итеративно: " + minIterative(array,array[1]));
        }
    }
}

