using System;
using System.Collections.Generic;

namespace Lab06
{
    class Program
    {
        static bool[,] board = new bool[8, 8];
        static HashSet<int> attckedRows = new HashSet<int>();
        static HashSet<int> attckedCols = new HashSet<int>();
        static HashSet<int> attckedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attckedRightDiagonals = new HashSet<int>();

        static void Main()
        {
            PlaceQueen(0);
        }

        public static void PlaceQueen(int row)
        {
            if (row == 8)
            {
                Print();
            }
            else
            {
                for (int col = 0; col < 8; col++)
                {
                    if (PlaceQueen(row, col))
                    {
                        Mark(row, col);
                        PlaceQueen(row + 1);
                        Unmark(row, col);
                    }
                }
            }
        }

        public static bool PlaceQueen(int row, int col)
        {
            return !attckedRows.Contains(row)
                   && !attckedCols.Contains(col)
                   && !attckedLeftDiagonals.Contains(row + col)
                   && !attckedRightDiagonals.Contains(row - col);
        }

        public static void Mark(int row, int col)
        {
            board[row, col] = true;
            attckedRows.Add(row);
            attckedCols.Add(col);
            attckedLeftDiagonals.Add(row + col);
            attckedRightDiagonals.Add(row - col);
        }

        public static void Unmark(int row, int col)
        {
            board[row, col] = false;
            attckedRows.Remove(row);
            attckedCols.Remove(col);
            attckedLeftDiagonals.Remove(row + col);
            attckedRightDiagonals.Remove(row - col);
        }

        public static void Print()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (board[row, col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
