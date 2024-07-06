using System.Globalization;

namespace Exercise6 {
    internal class Program {
        static void Main(string[] args) {
            double num1, num2, num3;
            string num1String, num2String, num3String;

            Console.WriteLine("Digite os 3 valores na mesma linha: ");

            string[] vetValues = Console.ReadLine().Split(' ');

            num1String = vetValues[0];
            num2String = vetValues[1];
            num3String = vetValues[2];

            num1 = double.Parse(num1String, CultureInfo.InvariantCulture);
            num2 = double.Parse(num2String, CultureInfo.InvariantCulture); 
            num3 = double.Parse(num3String, CultureInfo.InvariantCulture);

            //a)
            double triangleArea;
            double baseTriangle = num1;
            double highTriangle = num3;

            triangleArea = baseTriangle * highTriangle / 2;

            //b)
            double pi = 3.14159;
            double radius = num3;
            double radiusPow2 = Math.Pow(radius, 2);
            
            double circleArea = pi * radiusPow2 ;

            //c)
            double base1Trapeze = num1;
            double base2Trapeze = num2;
            double highTrapeze = num3;

            double trapezeArea = (base1Trapeze + base2Trapeze) * highTrapeze / 2;

            //d)
            double sideSquare = num2;
            double sidePow2 = Math.Pow(sideSquare, 2);

            double squareArea = sidePow2;

            //e)
            double side1Rectangle = num1;
            double side2Rectangle = num2;

            double rectangleArea = side1Rectangle * side2Rectangle;

            //show data exit
            Console.WriteLine("TRIANGULO = " + triangleArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + circleArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + trapezeArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + squareArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + rectangleArea.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}