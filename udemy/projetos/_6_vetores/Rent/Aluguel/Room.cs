namespace Aluguel
{
    internal class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public int NumRoom { get; set; }

        public Room(string name, string email, int numRoom)
        {
            Name = name;
            Email = email;
            NumRoom = numRoom;
        }

        public static void BusyRooms(Room[] rooms)
        {
            Console.WriteLine("Busy rooms: ");
            foreach (Room room in rooms)
            {
                if (room != null)
                {
                    Console.WriteLine(room);
                }

            }
        }

        public override string ToString()
        {
            string message = $"{NumRoom}: {Name}, {Email}";
            return message;
        }
    }
}