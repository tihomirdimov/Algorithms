using System;
using System.Linq;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long[] array = input.Split(' ').Select(x => long.Parse(x)).ToArray();
            long result = Sum(array, 0);
            Console.WriteLine(result);
        }

        static long Sum(long[] input, int index)
        {
            if (index == input.Length - 1)
            {
                return input[index];
            }

            return input[index] + Sum(input, index + 1);
        }
    }
}
