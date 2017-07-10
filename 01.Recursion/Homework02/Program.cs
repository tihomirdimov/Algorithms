using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int index = 0;
            NestedRecursion(array, index);
        }

        private static void NestedRecursion(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[index] = i;
                NestedRecursion(array, index + 1);
            }
        }
    }
}
