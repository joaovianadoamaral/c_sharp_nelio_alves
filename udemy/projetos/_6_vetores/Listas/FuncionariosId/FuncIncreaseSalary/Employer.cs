using System.Collections.Generic;
using System.Globalization;

namespace FuncIncreaseSalary
{
    internal class Employer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employer(long id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public static double IncreaseSalary(double increasePercentage, double salary)
        {
            salary *= (1 + increasePercentage / 100);
            return salary;
        }


        public static void ToFillInList(List<Employer> listEmployees, int lenght)
        {
            for (int countEmployees = 0; countEmployees < lenght; countEmployees++)
            {
                Console.WriteLine($"Emplyoee #{countEmployees + 1}");
                Console.Write("Id: ");
                long Id = long.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                listEmployees.Add(new Employer(Id, Name, Salary));

            }
        }

        public static Employer SearchIdInList(List<Employer> listEmployer, long id)
        {
            // 
            Employer? employer = listEmployer.Find(empl => empl.Id == id);

            if (employer == null)
            {
                Console.WriteLine("Id não existente.");
            }

            return employer;

        }

        public static void ShowEmployees(List<Employer> listEmployees)
        {
            Console.WriteLine("Updated list of employees: ");
            foreach (Employer employer in listEmployees)
            {
                Console.WriteLine(employer);
            }
        }

        public override string ToString()
        {
            string message = $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
            return message;
        }
    }
}
