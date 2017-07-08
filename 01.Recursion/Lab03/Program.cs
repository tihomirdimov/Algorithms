using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintFigure(input);
        }

        static void PrintFigure(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', n));
            PrintFigure(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}