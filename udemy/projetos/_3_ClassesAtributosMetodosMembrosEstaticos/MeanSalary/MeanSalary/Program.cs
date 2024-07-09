using System.Globalization;

namespace MeanSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //faça um programa para ler: nome e salário ( 2 )
            // mostre o salário médio dos funcionários
            Funcionario Func1, Func2;
            
            Func1 = new Funcionario();
            Func2 = new Funcionario();

            //funcionário 1
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            Func1.Name = Console.ReadLine();

            Console.Write("Salário: ");
            Func1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Funcionário 2
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            Func1.Name = Console.ReadLine();

            Console.Write("Salário: ");
            Func2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // calcula a média dos salários
            double Media = Mean(Func1.Salary, Func2.Salary);

            Console.WriteLine($"Salário médio: {Media.ToString("F2", CultureInfo.InvariantCulture)}");


        }

        static double Mean(double x, double y)
        {
            double MeanXY = (x + y) / 2.0;

            return MeanXY;
        }


    }
}
