using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class Unit
    {
        public Unit(string name, Boat ownBoat)
        {
            Name = name;
            OwnBoat = ownBoat;
        }

        public string Name { get; set; }
        public Boat OwnBoat { get; set; }
    }
}
