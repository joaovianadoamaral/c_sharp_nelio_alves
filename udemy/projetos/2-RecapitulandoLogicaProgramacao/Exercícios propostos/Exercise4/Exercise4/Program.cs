using System.Globalization;

namespace Exercise4 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Fazer um programa que leia o número de um funcionário,
             * seu número de horas trabalhadas,
             * o valor que recebe por hora
             * e calcula o salário desse funcionário.
             * A seguir, mostre o número e o salário do funcionário, 
             * com duas casas decimais
             */

            int numberInt, workedHours ;
            double hourValue, wage;

            Console.WriteLine("Write the employee number: ");
            
            string numberString = Console.ReadLine();
            numberInt = int.Parse(numberString);


            Console.WriteLine("Write the number of hours worked: ");

            string workedHoursString = Console.ReadLine();
            workedHours = int.Parse(workedHoursString);

            Console.WriteLine("Write the amount he earns per hour");

            string hourValueString = Console.ReadLine();
            hourValue = double.Parse(hourValueString, CultureInfo.InvariantCulture);

            wage = hourValue * workedHours;
            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine($"NUMBER = {numberInt}");
            Console.WriteLine("SALARY = U$ " + wage.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}