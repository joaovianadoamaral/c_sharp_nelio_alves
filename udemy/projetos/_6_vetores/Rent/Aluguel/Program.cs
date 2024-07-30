namespace Aluguel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte NumRooms = 10;
            Room[] rooms = new Room[NumRooms];

            Console.WriteLine("Digite a quantidade de estudantes que vão alugar os quartos: ");

            int NumStudents = int.Parse(Console.ReadLine());

            for (int contRoom = 0;  contRoom < NumStudents; contRoom++)
            {
                Console.WriteLine($"Rent #{contRoom+1}: ");
                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Email: ");
                string Email = Console.ReadLine();

                Console.Write("Room: ");
                int roomChoosed = int.Parse(Console.ReadLine());

                rooms[roomChoosed] = new Room(Name, Email, roomChoosed);

                Console.WriteLine();
            }

            Room.BusyRooms(rooms);

        }
    }
}
