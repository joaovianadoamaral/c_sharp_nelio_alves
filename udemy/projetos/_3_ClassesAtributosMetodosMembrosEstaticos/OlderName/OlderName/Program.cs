using System.Globalization;
namespace OlderName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1, person2;

            person1 = new Person();
            person2 = new Person();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.Name = Console.ReadLine();

            Console.Write("Idade: ");
            person1.Age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            person2.Name = Console.ReadLine();

            Console.Write("Idade: ");
            person2.Age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (person1.Age > person2.Age)
            {
                Console.WriteLine($"A pessoa mais velha é: {person1.Name}");
            }
            else if (person2.Age > person1.Age) { Console.WriteLine($"A pessoa mais velha é: {person2.Name}"); }

            else { Console.WriteLine("Ninguém é mais velho"); }

        }


    }
}
