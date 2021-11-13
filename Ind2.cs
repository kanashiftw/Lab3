using System;

namespace Ind2Lab3
{
    class Program
    {
        static int SumFirstHalf(int[] myArray,int sum, int i)
        {
            for (i = 0; i < (myArray.Length / 2); i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        static int SumSecondHalf(int[] myArray, int sum, int i)
        {
            for (i = (myArray.Length / 2); i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[10];
            Random rand = new Random();
            for (i = 0; i < 10; i++)
            {
                array[i] = rand.Next(-10,10);
                Console.Write($"|{array[i], 3}");
            }
            Console.Write("|");
            Console.WriteLine("");
            Console.WriteLine("Сумма элементов первой половины массива: " + SumFirstHalf(array,0,0));
            Console.WriteLine("Сумма элементов второй половины массива: " + SumSecondHalf(array,0,0));
            Console.WriteLine("Разность суммы левой половины элементов и правой: "+ ( SumFirstHalf(array, 0, 0) - SumSecondHalf(array, 0, 0)));
        }
    }
}
