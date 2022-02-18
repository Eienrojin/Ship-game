using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class Cannon : Weapon
    {
        public Cannon(string name, int damage, int durability, int magazine) : base(name, damage, durability, magazine)
        {
        }
    }
}
