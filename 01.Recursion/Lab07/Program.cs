using System;
using System.Collections.Generic;

namespace Lab07
{
    class Program
    {
        static List<char> path = new List<char>();   

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            char[,] lab = new char[x, y];

            for (int i = 0; i < x; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < y; j++)
                {
                    lab[i,j] = input[j];
                }
            }
            FindPaths(0, 0, 'S', lab);
        }

        private static void FindPaths(int row, int col, char direction, char[,] lab)
        {
            if (!IsValidCell(row, col, lab))
            {
                return;
            }
            path.Add(direction);
            if (lab[row, col] == 'e')
            {
                PrintPath();
            }
            else if (lab[row, col] != 'v')
            {
                lab[row, col] = 'v';
                FindPaths(row, col + 1, 'R', lab);
                FindPaths(row + 1, col, 'D', lab);
                FindPaths(row, col - 1, 'L', lab);
                FindPaths(row - 1, col, 'U', lab);
                lab[row, col] = '-';
            }
            path.RemoveAt(path.Count-1);
        }

        private static bool IsValidCell(int row, int col, char[,] lab)
        {
            return row >= 0 &&
                   row < lab.GetLength(0) &&
                   col >= 0 &&
                   col < lab.GetLength(1) &&
                   lab[row, col] != '*';
        }

        private static void PrintPath()
        {
            string result = string.Join("", path);

            Console.WriteLine(result.Substring(1));
        }
    }
}
