using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int n = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"максимальное:{n}");
        }
    }
}