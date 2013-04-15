using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EightQueens
{
    public class Queens
    {
        const int N = 8;
        static int[] queenSquares = new int[N];
        static List<int[]> solutions = new List<int[]>();

        public static void Main(String[] args)
        {
            placeQueen(file: 0);

            int count = 1;
            foreach (int[] solution in solutions)
            {
                Console.WriteLine(string.Format("Solution {0}:", count++));
                printBoard(solution);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static bool isNotAttacked(int file, int rank)
        {
            /* returns true if the placement of a Q 
             * is not attacked by any previously placed Q */

            // for all previously placed queens...
            for (int i = 1; i <= file; i++)
            {
                int queenrank = queenSquares[file - i];

                // same rank? 
                if (queenrank == rank) 
                    return false;

                // same diagonal?  
                if (queenrank == rank - i || queenrank == rank + i)
                    return false;
            }
            return true;
        }

        static void placeQueen(int file)
        {

            /* place a Q on a file so that
             * it is not attacked by any other Q */

            // Reached N queens?
            if (file == N)
            {
                solutions.Add((int[])queenSquares.Clone());
            }
            else
            {
                for (int rank = 0; rank < N; rank++)
                {
                    if (isNotAttacked(file, rank))
                    {
                        queenSquares[file] = rank;
                        placeQueen(file + 1);
                    }
                }
            }
        }

        static void printBoard(int[] queenSquares) {
            for (int file = 0; file < queenSquares.Length; file++)
            {
                for (int rank = 0; rank < queenSquares.Length; rank++)
                {
                    if (queenSquares[file] == rank)
                        Console.Write("Q ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
