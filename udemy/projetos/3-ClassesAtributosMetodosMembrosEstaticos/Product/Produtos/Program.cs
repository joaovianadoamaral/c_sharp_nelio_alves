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
            Console.WriteLine("Dados do produto: ");
            Console.WriteLine(product);

            // adicionando produtos ao estoque
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int AddQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            product.AddQuantityProducts(AddQuantity);
            TotalValueProduct = product.TotalValueInStock();

            //Mostrando dados atualizados
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(product);

            // removendo produtos do estoque
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int RemoveQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            product.RemoveQuantityProducts(RemoveQuantity);
            TotalValueProduct = product.TotalValueInStock();

            //Mostrando dados atualizados
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(product);


        }
    }
}
