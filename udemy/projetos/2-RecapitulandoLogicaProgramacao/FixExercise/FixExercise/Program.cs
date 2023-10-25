using System.Globalization;

namespace FixExercise {
    internal class Program {
        static void Main(string[] args) {
            
            string completeName, lastName;
            
            byte numberRoomsHouse, age;
            
            double productPrice, high;

            string[] inputVet;

            Console.WriteLine("Entre com seu nome completo:");
            completeName = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa ?");
            numberRoomsHouse = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço de um produto:");
            productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //no terminal é digitado com . -> pc português reconhece , 


            Console.WriteLine("\nEntre com seu último nome, idade e altura (mesma linha)");
            inputVet = Console.ReadLine().Split(' ');

            lastName = inputVet[0];
            age = byte.Parse(inputVet[1]);
            
            high = double.Parse(inputVet[2],CultureInfo.InvariantCulture);
            //no terminal é digitado com . -> pc português reconhece , 

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine($"{completeName}\n{numberRoomsHouse}");
            Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{lastName}\n{age}");
            Console.WriteLine(high.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}