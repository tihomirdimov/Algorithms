using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long result = Factorial(input);
            Console.WriteLine(result);
        }

        static long Factorial(long num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

    }
}