using System.Globalization;
namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            double pi = 3.14159; //Math.PI
            double radius, area;

            Console.WriteLine("digite o valor do Raio de um Círculo: ");
            radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(radius, 2);

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}