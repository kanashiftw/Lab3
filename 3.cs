using System;

namespace Zadanie3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] array = new int [12];
            Random rand = new Random();
            Console.WriteLine("Массив:");
            for (i = 0; i< array.Length; i++)
            {
                array[i] = rand.Next(-10,10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            int k;
            while (true)
            {
                try
                {
                   Console.WriteLine("Введите кол-во элементов, на которое будет осуществлен сдвиг.");
                    k = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }catch(OverflowException)
                {
                    Console.WriteLine("Такое значение нельзя обработать.");
                    continue;
                }break;
            }
            Console.WriteLine($"Сдвиг на {k} элементов влево");
            k = k % 12;
            if (k == 0 || k == 12)
            {
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
            }
            else
            {
                for (i = k; i < 12; i++)
                {
                    Console.Write(array[i] + " ");
                }
                for (i = 0; i <= k; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
