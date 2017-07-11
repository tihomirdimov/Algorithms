﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework04
{
    class Program
    {

        private static int stepsTaken = 0;
        private static Stack<int> source;
        private static readonly Stack<int> destination = new Stack<int>();
        private static readonly Stack<int> spare = new Stack<int>();

        private static void Main()
        {
            int numberOfDisks = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            PrintRodes();
            MoveDisks(numberOfDisks, source, destination, spare);
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine("Step #{0}: Moved disk", stepsTaken);
                PrintRodes();
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine("Step #{0}: Moved disk", stepsTaken);
                PrintRodes();
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }

        private static void PrintRodes()
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine();
        }
    }
}
