using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    internal class Rooms
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public override string ToString()
        {
            return RoomNumber + ": " + Name + ", " + Email;
        }
    }
}
