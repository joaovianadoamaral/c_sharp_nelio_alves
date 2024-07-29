using System.Globalization;
namespace MeanPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n produtos
            // cada produto possui preço e nome

            Console.WriteLine("Digite a quantidade de produtos: ");
            int AmountProducts = int.Parse(Console.ReadLine());

            Product[] products = new Product[AmountProducts];

            for (int cont = 0; cont < AmountProducts; cont++)
            {
                products[cont] = new Product();

                Console.WriteLine($"Insira o nome do produto {cont + 1}: ");
                products[cont].Name = Console.ReadLine();

                Console.WriteLine($"Insira o preço do produto {cont + 1}: ");
                products[cont].Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double Sum = 0;
            foreach (Product prod in products)
            {
                Sum += prod.Price;
            }

            double Mean = Sum / AmountProducts;
            Console.WriteLine($"AVERAGE PRICE = {Mean.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
