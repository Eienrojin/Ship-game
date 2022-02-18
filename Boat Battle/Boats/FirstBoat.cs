using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle.Boats
{
    internal class FirstBoat : Boat
    {
        public FirstBoat(string name, int hP, int maxHP) : base(name, hP, maxHP)
        {
        }

        void GetInfo()
        {
            Console.WriteLine("This is your the first ship" +
                "\nIt's lookin' vintage and worn by the left side" +
                "\nShip's name is JABODAV");
        }
    }
}
