using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];
            Console.WriteLine("Введите 10 чисел принадлежащих отрезку [0..10]: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Число {i + 1}: ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = GetSum(a);
            int count = kolvo(a);
            Console.WriteLine($"Сумма эл-ов: {sum}");
            Console.WriteLine($"Кол-во эл-ов: {count}");
        }
        static double GetSum(double[] array)
        {
            double sum = 0;
            foreach (var numb in array)
            {
                if (numb >= 0 && numb <= 10)
                {
                    sum += numb;
                }

            }
            return sum;
        }
        static int kolvo(double[] array)
        {
            int count = 0;
            foreach (var number in array)
            {
                if (number >= 0 && number <= 10)
                {
                    count++;
                }
            }
            return count;
        }
    }
}