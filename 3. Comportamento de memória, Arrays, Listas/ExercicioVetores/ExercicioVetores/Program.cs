using System;

namespace ExercicioVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms willl be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rooms[] vect = new Rooms[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #" + (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Rooms { Name = name, Email = email, RoomNumber = room };
            }

            Console.WriteLine("Busy rooms: ");
            foreach (Rooms X in vect)
            {
                if(X != null)
                    Console.WriteLine(X);
            }
        }
    }
}
