namespace Exercise1Pt2 {
    internal class Program {
        static void Main(string[] args) {
            // faça um programa para ler um número inteiro e dizer se ele é negativo ou não

            int num; 
            bool isnegative;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NÃO NEGATIVO");
            }

           


        }
    }
}
