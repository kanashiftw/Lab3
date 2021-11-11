using System;
namespace Zadanie4Lab3
{
    class Program
    {
        static int[,] Sum(int[,] array1, int[,] array2)
        {
            int[,] arraysum = new int[3, 3];
            for (int i = 0; i < 3; i++ )
            {
                for(int j = 0; j < 3; j++)
                {
                    arraysum[i, j] = array1[i, j] + array2[i, j];
                }
            }
            return arraysum;
        }
        static int[,] Razn(int[,] array1, int[,] array2)
        {
            int[,] arrayrazn = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayrazn[i,j] = array1[i, j] - array2[i, j];
                }
            }
            return arrayrazn;
        }
        static int[,] Mid(int[,] array1, int[,] array2)
        {
            int[,] arraymid = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arraymid[i, j] = (array1[i, j] + array2[i, j])/2;
                }
            }
            return arraymid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Поэлементное сложение или вычитание двух массивов");
            Random rand = new Random();
            int[,] array1 = new int [3, 3];
            int[,] array2 = new int [3, 3];
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = rand.Next(-10,10);
                    Console.Write($"|{array1[i, j], 5}|");
                    while (j == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 25));
                        break;
                    }
                }
            }
            Console.WriteLine("Второй массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = rand.Next(-10, 10);
                    Console.Write($"|{array2[i, j],5}|");
                    while (j == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(new String('-', 25));
                        break;
                    }
                }
            }
            int act;
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите действие: \n 1.Сумма массивов \n 2.Разность массивов \n 3.Среднее значение элементов");
                    act = int.Parse(Console.ReadLine());
                    if (act <1 || act > 3)
                    {
                        throw new Exception("InvalidValue");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели недопустимое значение.");
                    continue;
                }
                break;
            }
            switch (act) 
            {
                case (1):
                    Console.WriteLine("Сумма массивов:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"|{Sum(array1, array2)[i, j],5}|");
                            while (j == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(new String('-', 25));
                                break;
                            }
                        }
                    }break;
                case 2:
                    Console.WriteLine("Разность массивов:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"|{Razn(array1, array2)[i, j],5}|");
                            while (j == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(new String('-', 25));
                                break;
                            }
                        }
                    }break;
                case 3:
                    Console.WriteLine("Среднее значение элементов массивов:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"|{Mid(array1, array2)[i, j],5}|");
                            while (j == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(new String('-', 25));
                                break;
                            }
                        }
                    }break;
            }               
        }
    }
}