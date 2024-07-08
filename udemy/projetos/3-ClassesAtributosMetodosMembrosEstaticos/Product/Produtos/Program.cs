using System.Globalization;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando meu produto
            Product product = new Product();

            //leitura inicial de dados
            Console.WriteLine("Entre os Dados do Produto: ");
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();

            Console.Write("Preço:");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade Total no Estoque: ");
            product.Amount = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Mostrando os dados coletados
            double TotalValueProduct = product.TotalValueInStock();
            
            Console.WriteLine();
            Console.Write("Dados do produto: ");
            Console.Write($"{product.Name}, ${product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            Console.Write($"{product.Amount} unidades, ");
            Console.WriteLine($"Total: $ {TotalValueProduct.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            // adicionando produtos ao estoque
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int AddQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            product.AddQuantityProducts(AddQuantity);
            TotalValueProduct = product.TotalValueInStock();

            //Mostrando dados atualizados
            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.Write($"{product.Name}, ${product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            Console.Write($"{product.Amount} unidades, ");
            Console.WriteLine($"Total: $ {TotalValueProduct.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            // removendo produtos do estoque
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int RemoveQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            product.RemoveQuantityProducts(RemoveQuantity);
            TotalValueProduct = product.TotalValueInStock();

            //Mostrando dados atualizados
            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.Write($"{product.Name}, ${product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            Console.Write($"{product.Amount} unidades, ");
            Console.WriteLine($"Total: $ {TotalValueProduct.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

        }
    }
}
