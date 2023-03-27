using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms2
{
    internal class SpiralMatrix1
    {
        /*[[1,2,3,4],
             * [5,6,7,8],
             * [9,10,11,12]]
            
            Output[1,2,3,4,
                8,12,11,10,
                9,5,6,7]

            */
        public static void Spiral(int row, int col, int[,] Matrix)
        {
            int[,] spiralMatrix = new int[row, col];

            int i, start_row = 0, start_col = 0;

            while(start_row < row && start_col < col)
            {
                for( i = start_col; i < col; i++)
                {
                    Console.Write(Matrix[start_row, i] + " ");
                }
                start_row++;
                for( i = start_row; i < row; i++)
                {
                    Console.Write(Matrix[i,col - 1] + " ");
                }
                col--;
                if (start_row < row)
                {
                    for (i = col-1; i >= start_col; i--)
                    {
                        Console.Write(Matrix[row - 1, i] + " ");
                    }
                    row--;
                }
                if (start_col < col)
                {
                    for (i = row-1; i >= start_row; i--)
                    {
                        Console.Write(Matrix[i, start_col] + " ");
                    }
                    start_col++;
                }

            }

        }
        public static void Main(string[] args)
        {
            int row = 3;
            int col = 4;
            int[,] matrix = { { 1, 2, 3, 4 },
                              { 5, 6, 7, 8 },
                              { 9, 10, 11, 12 }};

            Spiral(row, col, matrix);
            /*int row = 4;
            int col =4;
            int[,] matrix = { { 1, 2, 3, 4 },
                              { 5, 6, 7, 8 },
                              { 9, 10, 11, 12 },
                                {13, 14, 15, 16 }};

            Spiral(row, col, matrix);
            */
        }
    }
}
