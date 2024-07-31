using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando uma lista vazia
            List<int> listaVazia = new List<int>();

            // criando uma lista não vazia
            List<string> names = new List<string> { "João", "Ana", "Maria", "José"};
            
            // mostrar todos os nomes de uma lista
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // tamanho de uma lista
            Console.WriteLine(names.Count); // 4

            //primeiro elemento que começa com A
            string FirstAPosition= names.Find(func => func[0] == 'A');
            Console.WriteLine(FirstAPosition);

            // último elemento que começa com J
            string LastJName = names.FindLast(func => func[0] == 'J');
            Console.WriteLine(LastJName);


            string Joao = names.FindLast(func => func == "João");
            Console.WriteLine(Joao);

            // acha todas os nomes começados com J
            Console.WriteLine("-------------------------------------------");
            List<string> Jotas = names.FindAll(func => func[0] == 'J');
            foreach (string jotas in Jotas)
                Console.WriteLine(jotas);

            // remove joão da lista
            Jotas.Remove("João");

            // remove todos os elementos que começam com M
            names.RemoveAll(func => func[0] == 'M');

            // remove o primeiro elemento de names
            names.RemoveAt(0);

            // remove um range de elementos
            names.RemoveRange(0, 10);

        }
    }
}
