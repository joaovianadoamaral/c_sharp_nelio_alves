using System.Globalization;

namespace AreaTriangulo {
    internal class Program {
        static void Main(string[] args) {
            
            //leia 3 lados do triangulo e mostre a área dele
            double lado1,lado2, lado3;
            double semiperimetro, area, heeron;

            Console.WriteLine("Digite os 3 lados dos triângulos: ");
            lado1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lado2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lado3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            semiperimetro = (lado1 + lado2 + lado3) / 2;
            heeron = semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3);
            area = Math.Sqrt(heeron);

            Console.WriteLine("Area do Triangulo informado é: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"Lados dos triangulos: {lado1} {lado2} {lado3}.");
            

        }
    }
}
