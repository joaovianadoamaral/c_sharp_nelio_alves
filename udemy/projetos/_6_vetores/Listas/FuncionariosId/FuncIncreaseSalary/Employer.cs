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


        public static void ChooseIdIncreaseOfList(List<Employer> listEmployer, long idToIncrease, double increasePercentage)
        {
            foreach (Employer employer in listEmployer)
            {
                if (employer.Id == idToIncrease)
                {
                   employer.Salary = IncreaseSalary(increasePercentage, employer.Salary);
                }
            }
        }

        public override string ToString()
        {
            string message = $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
            return message;
        }
    }
}
