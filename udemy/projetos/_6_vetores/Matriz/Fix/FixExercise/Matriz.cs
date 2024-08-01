using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixExercise
{
    internal class Matriz
    {
        public static int[,] PreencherMatrizInt(int rows, int columns)
        {
            int[,] mat = new int[rows, columns];
            string[] lineNumbers;

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine($"Digite a linha #{row} da matriz: ");
                lineNumbers = Console.ReadLine().Split(' ');

                for (int col = 0; col < columns; col++)
                {
                    mat[row, col] = int.Parse(lineNumbers[col]);
                }

            }

            return mat;

        }

        public static void PositionX(int[,] mat, int num)
        {
            int[] Position = new int[2];

            int CountElements = 0;

            // percorrer a matriz
            for (int row = 0; row < mat.GetLength(0); row++)
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    if (mat[row, col] == num)
                    {
                        Position[0] = row;
                        Position[1] = col;
                        Console.WriteLine($"Position {row}, {col}: ");

                        LeftPosition(mat, Position);
                        UpPosition(mat, Position);
                        RightPosition(mat, Position);
                        DownPosition(mat, Position);

                        CountElements++;
                    }
                }
        }

        public static void LeftPosition(int[,] mat, int[] positionNum)
        {
            bool IsInFirstColumn = positionNum[1] == 0;

            if (!IsInFirstColumn)
            {
                int LeftRow = positionNum[0];
                int LeftCol = positionNum[1] - 1;

                Console.WriteLine($"Left: {mat[LeftRow, LeftCol]}");
            }
        }

        public static void UpPosition(int[,] mat, int[] positionNum)
        {
            bool IsInFirstRow = positionNum[0] == 0;

            if (!IsInFirstRow)
            {
                int UpRow = positionNum[0] - 1;
                int UpCol = positionNum[1];

                Console.WriteLine($"Up: {mat[UpRow, UpCol]}");
            }
        }

        public static void RightPosition(int[,] mat, int[] positionNum)
        {
            int ColMatLenght = mat.GetLength(1);
            bool IsInLastColumn = positionNum[1] == ColMatLenght - 1;

            if (!IsInLastColumn)
            {
                int RightRow = positionNum[0];
                int RightCol = positionNum[1] + 1;

                Console.WriteLine($"Right: {mat[RightRow, RightCol]}");
            }
        }

        public static void DownPosition(int[,] mat, int[] positionNum)
        {
            int RowMatLenght = mat.GetLength(0);
            bool IsInLastRow = positionNum[0] == RowMatLenght - 1;

            if (!IsInLastRow)
            {
                int DownRow = positionNum[0] + 1;
                int DownCol = positionNum[1];

                Console.WriteLine($"Down: {mat[DownRow, DownCol]}");
            }
        }
    }
}
