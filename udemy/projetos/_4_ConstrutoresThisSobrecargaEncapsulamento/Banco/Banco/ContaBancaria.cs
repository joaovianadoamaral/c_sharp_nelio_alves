using System.Globalization;

namespace Banco
{
    internal class ContaBancaria
    {
        private string _nomeTitularConta;
        public decimal Saldo { get; private set; }
        public ulong NumeroConta { get; private set; }

        public ContaBancaria()
        {
            Console.Write("Entre o número da conta: ");
            NumeroConta =  ulong.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            NomeTitularConta = Console.ReadLine();
            
            DepositoInicial();
        }

        public string NomeTitularConta
        {
            get
            {
                return _nomeTitularConta;
            }
            set
            {
                string? Nome;
                int TamanhoString = value.Length;
                bool NomeNulo = value == null;
                bool NomeMaiorQueUmaLetra = TamanhoString > 1;

                _nomeTitularConta = value;

                if (NomeNulo || !NomeMaiorQueUmaLetra)
                {
                    while (true)
                    {
                        Console.WriteLine("Digite um campo não nulo para o nome do titular");

                        Nome = Console.ReadLine();
                        if (Nome != null)
                        {
                            _nomeTitularConta = Nome;
                            break;
                        }

                    }
                }
            }
        }

        public void Deposito(decimal deposito)
        {
            bool DepositoValido = deposito > 0;
            if (DepositoValido)
            {
                Saldo += deposito;
            }
        }

        public void Saque(decimal saque)
        {
            int Taxa = 5;
            
            bool SaqueSuperiorAoSaldo= (saque + Taxa) > Saldo;
            bool SaqueNulo = saque <= 0;

            if (SaqueSuperiorAoSaldo || SaqueNulo)
            {
                Console.WriteLine("Você não pode sacar esse valor!");
            }

            if (!SaqueSuperiorAoSaldo && !SaqueNulo)
            {
                Saldo -= (saque + Taxa);
            }
        }

        private void DepositoInicial()
        {
            string? RespostaUsuario;
            Console.Write("Haverá depósito inicial (s/n)? ");
            RespostaUsuario = Console.ReadLine().ToLower();

            bool Depositar = RespostaUsuario == "s";
            bool NaoDepositar = RespostaUsuario == "n";

            bool RespostaInvalida = RespostaUsuario != "s" && RespostaUsuario != "n";

            if (RespostaInvalida)
            {
                DepositoInicial();
            }

            if (Depositar){
                decimal ValorInicial;
                Console.Write("Entre com o valor do depósito inicial: ");
                ValorInicial = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Deposito(ValorInicial);

            }

            if (NaoDepositar)
            {
                decimal ValorInicial = 0;
                Deposito(ValorInicial);
            }

        }

        public override string ToString()
        {
            string message;

            message =
                $"Conta {NumeroConta}, " +
                $"Titular: {_nomeTitularConta}, " +
                $"Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}" +
                "\n";

            return message;
        }

    }
}
