using System;

namespace Zadanie7Lab3
{
    class Program
    {       
        static int fibonacchi(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;

            return fibonacchi(n - 2) + fibonacchi(n - 1);
        }
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите порядковый номер числа Фибоначчи.");
                    num = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Недопустимое значение");
                    continue;
                }break;
            }
            Console.WriteLine($"Число фибоначчи под номером {num}:");
            Console.WriteLine(fibonacchi(num));
            /*Не жалею, не зову, не плачу,
              Все пройдет, как с белых яблонь дым.
              Увяданья золотом охваченный,
              Я не буду больше молодым.*/
        }
    }
}

