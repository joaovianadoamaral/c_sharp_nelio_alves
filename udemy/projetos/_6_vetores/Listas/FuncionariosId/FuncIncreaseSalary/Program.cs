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
            
            List<Employer> listEmployees = new List<Employer>();
            Employer.ToFillInList(listEmployees, numberEmployees);


            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase:  ");
            long IdWillIncreaseSalary = long.Parse(Console.ReadLine());

            Employer employerChoosed = Employer.SearchIdInList(listEmployees, IdWillIncreaseSalary);

            if (employerChoosed != null)
            {
                Console.Write("Enter the percentage (%):  ");
                double IncreasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employerChoosed.Salary = Employer.IncreaseSalary(IncreasePercentage, employerChoosed.Salary);
            }

            Console.WriteLine();

            Employer.ShowEmployees(listEmployees);


        }
    }
}
