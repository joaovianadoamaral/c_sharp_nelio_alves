using System.Globalization;

namespace AreaTrianguloComPOO {
    internal class Program {
        static void Main(string[] args) {
            TrianguloPOO Triangle1, Triangle2;

            Triangle1 = new TrianguloPOO();
            Triangle2 = new TrianguloPOO();

            // recebendo lados dos triângulos
            Console.WriteLine("Digite os lados do primeiro Triângulo: ");
            Triangle1.Side1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle1.Side2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle1.Side3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os lados do primeiro Triângulo: ");
            Triangle2.Side1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle2.Side2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle2.Side3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // seu triangulo existe?
            Triangle1.TriangleConditionExistence();
            Console.WriteLine($"O primeiro Triângulo existe? {Triangle1.ConditionExistence}");

            Triangle2.TriangleConditionExistence();
            Console.WriteLine($"O Segundo Triângulo existe? {Triangle2.ConditionExistence}");

            // usa o método TriangleAreaHeeron para fazer o cálculo da área e atribuir no atributo área
            Triangle1.TriangleAreaHeron();
            Triangle2.TriangleAreaHeron();

            Console.WriteLine($"A área do triângulo 1 é : {Triangle1.Area} ");
            Console.WriteLine($"A área do triângulo 2 é : {Triangle2.Area} ");


        }
    }
}

