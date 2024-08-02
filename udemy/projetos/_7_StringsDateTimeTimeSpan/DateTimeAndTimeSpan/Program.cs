using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Ticks);

            TimeSpan timeSpan = new TimeSpan(0, 1, 30);
            Console.WriteLine(timeSpan);


            dateTime = DateTime.Now;
            int day = dateTime.Day;

            int dayOfYear = dateTime.DayOfYear;
            Console.WriteLine(dayOfYear);

            DateTime agora = DateTime.Now;
            DateTime vencimento = agora.AddDays(7);

            Console.WriteLine(agora);
            Console.WriteLine(vencimento);

        }
    }
}