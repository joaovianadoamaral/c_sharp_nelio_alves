using System.Diagnostics.Tracing;

namespace EvenOdd {
    internal class Program {
        static void Main(string[] args) {
            bool even;
            ulong numberUlong;
            string strNumber;

            Console.WriteLine("Digite um número: ");
            strNumber = Console.ReadLine();

            numberUlong = ulong.Parse(strNumber);

            if (numberUlong % 2 == 0) {
                even = true;
            }
            else 
            {
                even = false;
            }

            Console.WriteLine($"O seu número é par: {even}");
        }
    }
}
