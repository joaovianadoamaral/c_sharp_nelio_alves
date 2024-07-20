using System.Globalization;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal UltimoSaque, UltimoDeposito;

            ContaBancaria joao = new ContaBancaria();

            Console.WriteLine();
            MostrarDadosConta(joao);

            Console.Write("Entre um valor para depósito: ");
            UltimoDeposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            joao.Deposito(UltimoDeposito);

            MostrarDadosConta(joao);

            Console.Write("Entre um valor para saque: ");
            UltimoSaque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            joao.Saque(UltimoSaque);
            
            MostrarDadosConta(joao);

        }

        static void MostrarDadosConta(object conta)
        {
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }

    }
}
