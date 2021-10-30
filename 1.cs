using System;

namespace Zadanie1Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            check:
            try
            {
                Console.WriteLine("Введите кол-во эмементов массива");
                i = int.Parse(Console.ReadLine());
                while (i <= 0)
                {
                    Console.WriteLine($"Массив не может содежать {i} элементов");
                    i = int.Parse(Console.ReadLine());
                }
            }catch(FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзя обработать");
                goto check;
            }
            int[] array = new int[i];
            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-30, 45);
            }
            Console.WriteLine(new String('-', 31));
            Console.WriteLine("Элементы массива:");
            int j = 0;
            foreach (int element in array) 
            {
                Console.Write(element + " ");
                j++;
                while (j > 9)
                {
                    Console.WriteLine("");
                    Console.WriteLine(new String('-', 31));
                    j = 0;
                }
            }
            Console.WriteLine("");
            Console.WriteLine(new String('-', 31));
            Console.WriteLine("Неотрицательные элементы массива в обратном порядке:");
            Array.Reverse(array);
            Console.WriteLine("");
            Console.WriteLine(new String('-', 31));
            foreach (int element in array)
            {
                if (element > 0)
                {
                    Console.Write(element + " ");
                    j++;
                    while (j > 9)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 31));
                        j = 0;
                    }
                }           
            }
            Console.WriteLine("");
            Console.WriteLine(new String('-', 31));
        }
        public static void Reverse (int[] array){}
    }
}