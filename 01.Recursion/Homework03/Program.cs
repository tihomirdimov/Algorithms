using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            GenerateCombinations(n, k, new int[k], 0, 1);
        }

        private static void GenerateCombinations(int n, int k, int[] array, int index, int start)
        {
            if (index == array.Length)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                array[index] = i;
                GenerateCombinations(n, k, array, index + 1, i);
            }
        }
    }
}
