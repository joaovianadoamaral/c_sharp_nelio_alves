using System.Collections.Generic;
using System.Globalization;

namespace FuncIncreaseSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());
            List<Employer> listEmployee = new List<Employer>();

            Console.WriteLine();

            for (int countEmployees = 0; countEmployees < numberEmployees; countEmployees++)
            {
                Console.WriteLine($"Emplyoee #{countEmployees + 1}");
                Console.Write("Id: ");
                long Id = long.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine();

                listEmployee.Add(new Employer(Id, Name, Salary));

            }

            Console.Write("Enter the employee id that will have salary increase:  ");
            long IdWillIncreaseSalary = long.Parse(Console.ReadLine());


            Console.Write("Enter the percentage (%):  ");
            double IncreasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employer.ChooseIdIncreaseOfList(listEmployee, IdWillIncreaseSalary, IncreasePercentage);

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach(  Employer employer in listEmployee)
            {
                Console.WriteLine(employer);
            }

        }
    }
}
