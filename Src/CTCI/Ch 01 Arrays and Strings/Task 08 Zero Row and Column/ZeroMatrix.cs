using System.Collections.Generic;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_08_Zero_Row_and_Column
{
    public class ZeroMatrix
    {
        private static void ZeroRow(int[,] matrix, int row)
        {
            for (var col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }

        private static void ZeroCol(int[,] matrix, int col)
        {
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = 0;
            }
        }

        public int[,] Zero1(int[,] matrix)
        {
            var rowsToZero = new HashSet<int>();
            var colsToZero = new HashSet<int>();

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        rowsToZero.Add(row);
                        colsToZero.Add(col);
                    }
                }
            }

            foreach (var row in rowsToZero)
            {
                ZeroRow(matrix, row);
            }

            foreach (var col in colsToZero)
            {
                ZeroCol(matrix, col);
            }

            return matrix;
        }

        public int[,] Zero2(int[,] matrix)
        {
            var firstColHasZero = false;

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] == 0)
                {
                    firstColHasZero = true;
                    break;
                }
            }

            var firstRowHasZero = false;

            for (var col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[0, col] == 0)
                {
                    firstRowHasZero = true;
                    break;
                }
            }

            for (var row = 1; row < matrix.GetLength(0); row++)
            {
                for (var col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        matrix[0, col] = 0;
                        matrix[row, 0] = 0;
                    }
                }
            }

            for (var row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] == 0)
                {
                    ZeroRow(matrix, row);
                }
            }

            for (var col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[0, col] == 0)
                {
                    ZeroCol(matrix, col);
                }
            }

            if (firstRowHasZero)
            {
                ZeroRow(matrix, 0);
            }

            if (firstColHasZero)
            {
                ZeroCol(matrix, 0);
            }

            return matrix;
        }
    }
}