using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal abstract class Boat
    {
        public Boat(string name, int hP, int maxHP)
        {
            MaxHP = maxHP;

            if (hP > MaxHP)
            {
                hP = MaxHP;
                HP = hP;
            }
            else
            {
                HP = hP;
            }
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public Weapon UsingWeapon { get; set; }

        public void GetDamage(int damage)
        {
            HP -= damage;
        }

        public override string ToString()
        {
            if (UsingWeapon is not null)
            {
                return $"This boat is {Name}" +
                $"\nIt has {HP} HP" +
                $"\nAnd it's using {UsingWeapon.Name}\n";
            }
            else
            {
                return $"This boat is {Name}" +
                $"\nIt has {HP} HP" +
                $"\nIt hasn't any weapon";
            }
        }
    }
}
