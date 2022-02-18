using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal abstract class Weapon : ILootable
    {
        public Weapon(string name, int damage, int durability, int magazine)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Magazine = magazine;
        }

        public string Name { get; set; }
        private int Damage { get; set; }
        public int Durability { get; set; }
        public int Magazine { get; set; }

        public int Shoot()
        {
            Random random = new();

            if (CheckDestroy())
            {
                if (Magazine != 0)
                {
                    Durability -= random.Next(0, 13);
                    Magazine--;

                    return Damage;
                }
                else
                {
                    Console.WriteLine("The magazine is empty!");

                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private bool CheckDestroy()
        {
            if (Durability <= 0)
            {
                Console.WriteLine("This weapon is broken!" +
                    "\nChoose another one");

                return false;
            }
            else
            {
                return true;
            }
        }

        public ILootable GetUpcastItem()
        {
            return this;
        }

        public override string ToString()
        {
            return $"{Name}" +
                $"\nDamage = {Damage}" +
                $"\nDurability {Durability}" +
                $"\nIt has {Magazine} bullet(s)\n";
        }
    }
}
