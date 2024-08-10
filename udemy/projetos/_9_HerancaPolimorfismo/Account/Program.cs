using Contas.Entities;

namespace Contas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);


            Account acc = new Account(1001, "Alex", 0.0);

            //upcasting
            Account acc1 = account;
            Account acc2 = new BusinessAccount(1003, "Anna", 0.0, 200.0);

            // downcasting
            BusinessAccount acc3 = (BusinessAccount)acc2;
            acc3 = acc2 as BusinessAccount;


        }
    }
}
