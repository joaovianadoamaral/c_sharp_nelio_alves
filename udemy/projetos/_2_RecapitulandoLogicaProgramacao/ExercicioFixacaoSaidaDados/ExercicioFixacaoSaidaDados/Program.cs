using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program {
        static void Main(string[] args) {

            //incie as variaveis pedidas
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string espacoExtra = "\n";

            //produza a seguinte saída na tela usando as variáveis:
            /*
             Produtos:
             Computador, cujo proço é $2100,00
             Mesa de escritório, cujo preço é $650,50
             
             Registro: 30 ans de idade, código 5290 e gênero : M

            Medida com oito casas decimais: 53,23456700
            arredondado(Três casas decimais): 53,235
            Separador decimal invariant culture: 53.235
             */
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:f2} {espacoExtra}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}{espacoExtra}");
            
            Console.WriteLine($"Medida com 8 casas decimais: {medida:f8}");
            Console.WriteLine($"Arredondado(Três casas decimais): {medida:f3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("f3", CultureInfo.InvariantCulture));

        }
    }
}