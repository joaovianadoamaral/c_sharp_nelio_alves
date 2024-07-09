namespace DataInput {
    internal class Program {
        static void Main(string[] args) {

            //declaração de variáveis
            string frase, a, b, c, x, y, z, aux;
            char separador;
            string[] vetorString;

            frase = Console.ReadLine();
            
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            aux = Console.ReadLine();

            separador = ' ';//espaço
            vetorString = aux.Split(separador);
            //vetorString = Console.ReadLine().Split(separado); -> forma sem usar uma variável auxiliar

            a = vetorString[0];
            b = vetorString[1];
            c = vetorString[2];


            Console.WriteLine($"\nVocê digitou:\n{frase}\n{x}\n{y}\n{z}\n{a}\n{b}\n{c}\n");

        }
    }
}