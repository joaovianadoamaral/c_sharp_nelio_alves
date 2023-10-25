using System;
using System.Globalization;

namespace DataOut// Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            float precoProduto = 6.50F;
            Console.Write(precoProduto);

            double saldo = 10.12345;
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture));

            string nome = "João Vitor Viana do Amaral";
            int idade = 21;

            //PlaceHolder
            Console.WriteLine("{0} tem {1} anos com {2:f2} de saldo na conta", nome, idade, saldo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos com {saldo:f3} de saldo na conta");

            //concatenação
            Console.WriteLine(nome + " tem " + idade + " anos com " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " de saldo na conta");

        }
    }
}