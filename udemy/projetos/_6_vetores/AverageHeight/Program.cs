using System.Globalization;
namespace AverageHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número N: ");
            int num =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura de N pessoas: ");

            float[] heighs = new float[num];

            for (int cont = 0; cont < num; cont++)
            {
                heighs[cont] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            float Avg = Mean(heighs);

            Console.WriteLine($"AVERAGE HEIGHT = {Avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static float Mean(float[] numbers )
        {
            float AvgHeight;
            float sum = 0;

            foreach(float number in numbers)
            {
                sum += number;
            }
            AvgHeight = sum / numbers.Length;

            return AvgHeight;
        }        
    }
}

