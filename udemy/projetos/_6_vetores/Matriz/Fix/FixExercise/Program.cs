namespace FixExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // leia dois inteiros M e N;
            // preencha matriz [ M, N ]

            // Leia um número x que pertença a matriz

            // mostre a posição
            // mostre os números a esquerda, a direita, a baixo, a cima.

            int Columns, Rows;

            Console.Write("Digite a quantidade de linhas: ");
            Rows = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.Write("Digite a quantidade de Colunas: ");
            Columns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // preencher 
            int[,] Mat = Matriz.PreencherMatrizInt(Rows, Columns);

            //numero pertencente
            Console.Write("Digite um numero que pertence a matriz: ");
            int NumInMat = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Matriz.PositionX(Mat, NumInMat);


        }
    }
}
