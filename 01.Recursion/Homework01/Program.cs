using System;
using System.Linq;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => int.Parse(e))
                .ToArray();
            Reverse(0, input.Length - 1, input);
            var output = String.Join(" ", input);
            Console.WriteLine(output);
        }

        private static void Reverse(int start, int end, int[] array)
        {
            if (start < end)
            {
                var temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                Reverse(start + 1, end - 1, array);
            }
        }
    }
}
