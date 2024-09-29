using System;


namespace gostev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = 20;
            int number1 = 10;
            int number2 = 2;
            int cube = GetCube(number);
            int quad = GetQuad(number);
            int summa = GetSumma(number, number1);
            int answer = GetAnswer(number, number1, number2);
            Console.WriteLine(GetDay());
            Console.WriteLine(GetMin());
            Console.WriteLine($"куб числа {number}: {cube}  ");
            Console.WriteLine($"квадрат {number}: {quad} ");
            Console.WriteLine($"сумма {number}+{number1}: {summa} ");
            Console.WriteLine($"решение ({number}-{number1}) / {number2} : {answer} ");
        }

        static int GetCube(int number)
        {
            return number * number * number;
            Console.ReadLine();
        }

        static int GetQuad(int number)
        {
            return number * number;
        }

        static int GetSumma(int number, int number1)
        {
            return number + number1;
        }

        static int GetAnswer(int number, int number1, int number2)
        {
            return (number - number1) / number2;
        }

        static string GetDay()
        {
            Console.WriteLine("ввести число чтобы получить день");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                return "понедельник";
            }
            if (i == 2)
            {
                return "вторник";
            }
            if (i == 3)
            {
                return "среда";
            }
            if (i == 4)
            {
                return "четверг";
            }
            if (i == 5)
            {
                return "пятница";
            }
            if (i == 6)
            {
                return "суббота";
            }
            if (i == 7)
            {
                return "воскресенье";
            }
            else
            {
                return "такого дня нету";
            }
        }

        static string GetMin()
        {
            Console.WriteLine("ввести первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввести второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                return ($"число {a} больше чем число {b}");
            }
            else
            {
                return ($"число {b} больше чем число {a}");
            }
        }
    }
}
