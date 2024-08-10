using Contract.Entities;
using Contract.Entities.Enums;
using System.Globalization;

namespace Contract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string DepartamentName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string WorkerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int WorkerContracts = int.Parse(Console.ReadLine());

            Departament dept = new Departament(DepartamentName);
            Worker worker = new Worker(WorkerName, level, BaseSalary, dept);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int contractNumber = 1; contractNumber <= n; contractNumber++)
            {
                Console.WriteLine($"Enter #{contractNumber} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
