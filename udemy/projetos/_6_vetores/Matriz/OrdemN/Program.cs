namespace OrdemN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro N: ");
            int lenghtMatriz = int.Parse(Console.ReadLine());

            int[,] ints = PreencherMatrizOrdemN(lenghtMatriz);

            int[] MainDiagonalInts = MainDiagonal(ints);

            Console.WriteLine("Main diagonal: ");
            ShowVetor(MainDiagonalInts);

            Console.WriteLine();

            int AmountNegativeNumbers = CountNegativeNumbers(ints);
            Console.WriteLine($"Negative numbers = {AmountNegativeNumbers}");

        }

        static int[,] PreencherMatrizOrdemN(int lenghtMatriz)
        {
            int[,] ints = new int[lenghtMatriz, lenghtMatriz];

            for (int row = 0; row < lenghtMatriz; row++)
            {
                for (int col = 0; col < lenghtMatriz; col++)
                {
                    int lastElement = int.Parse(Console.ReadLine());

                    ints[row, col] = lastElement;
                }
            }

            return ints;
        }

        static int[] MainDiagonal(int[,] ints)
        {
            int Rows = ints.GetLength(0);
            int Columns = ints.GetLength(1);

            int[] MainDiagonal = new int[Rows];

            int Index = 0;

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    if (row == col)
                    {
                        MainDiagonal[Index] = ints[row, col];
                        Index++;
                    }
                }
            }

            return MainDiagonal;
        }

        static void ShowVetor(int[] ints)
        {
            foreach (int integer in ints)
            {
                Console.Write($"{integer} ");
            }
        }

        static int CountNegativeNumbers(int[,] ints)
        {
            int Count = 0;

            int Rows = ints.GetLength(0);
            int Columns = ints.GetLength(1);

            bool IsNegativeNumber;

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    IsNegativeNumber = ints[row, col] < 0;

                    if (IsNegativeNumber)
                    {
                        Count++;
                    }
                }
            }

            return Count;
        }
    }
}
