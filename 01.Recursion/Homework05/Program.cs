using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            var end = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            int start = 1;
            int[] arr = new int[k];
            int index = 0;
            GenerateCombinationNoRepetitions(arr, index, start, end);
        }

        private static void GenerateCombinationNoRepetitions(int[] arr, int index, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                GenerateCombinationNoRepetitions(arr, index + 1, i + 1, end);
            }
        }
    }
}