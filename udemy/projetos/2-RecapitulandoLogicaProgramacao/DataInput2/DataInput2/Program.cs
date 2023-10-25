using System.Globalization;
namespace DataInput2 {
    internal class Program {
        static void Main(string[] args) {

            int n1, idade;
            char ch, sexo;
            double n2, altura;
            string[] vetorString;
            string nome;

            n1 = int.Parse(Console.ReadLine());
            
            ch = char.Parse(Console.ReadLine());
            
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vetorString = Console.ReadLine().Split(' ');

            Console.WriteLine($"\n{n1}\n{ch}\n{n2}");

            nome = vetorString[0];
            sexo = char.Parse(vetorString[1]);
            idade = int.Parse(vetorString[2]);
            altura = double.Parse(vetorString[3], CultureInfo.InvariantCulture);

            //dados de uma pessoa
            Console.WriteLine($"{nome}\n{sexo}\n{idade}\n{altura:f2}");

            //se quisesse mostrar o número com . usar concatenação + var.ToString("F1", CultureInfo.InvariantCulture);

            Console.WriteLine(vetorString[3]);

        }
    }
}