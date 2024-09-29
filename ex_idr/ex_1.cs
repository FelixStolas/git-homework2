using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите a в градусах: ");
            double a = Convert.ToDouble(Console.ReadLine());



            double rad = a * (3.14 / 180);
            Console.WriteLine($"число a в радианах равно : {rad}");

            double ctg = CalculateCtg(rad);
            Console.WriteLine($"ктг равен: {ctg}");

        }
        static double CalculateCtg(double radians)
        {
            double sin = Math.Sin(radians);
            if (sin == 0)
            {
                throw new DivideByZeroException("ошибка");
            }
            return Math.Cos(radians) / sin;
        }
    }
}