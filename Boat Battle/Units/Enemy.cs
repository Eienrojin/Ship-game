using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class Enemy : Unit
    {
        public Enemy(string name, Boat ownBoat) : base(name, ownBoat)
        {
        }
    }
}
