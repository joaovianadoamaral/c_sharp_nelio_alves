using System.Globalization;
namespace Exercise5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write the code, amount and price of piece 1 :");
            string[] vetProduct1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Write the code, amount and price of piece 2 :");
            string[] vetProduct2 = Console.ReadLine().Split(' ');

            int codePiece1, codePiece2;
            int amountPiece1, amountPiece2;
            double pricePiece1, pricePiece2;

            double total;

            codePiece1 = int.Parse(vetProduct1[0]);
            codePiece2 = int.Parse(vetProduct2[0]);

            amountPiece1 = int.Parse(vetProduct1[1]);
            amountPiece2 = int.Parse(vetProduct2[1]);

            pricePiece1 = double.Parse(vetProduct1[2], CultureInfo.InvariantCulture);
            pricePiece2 = double.Parse(vetProduct2[2], CultureInfo.InvariantCulture);


            total = amountPiece1 * pricePiece1 + amountPiece2 * pricePiece2;

            Console.WriteLine("\n---------------------------------------------\n");
            Console.WriteLine("VALOR A PAGAR = R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}