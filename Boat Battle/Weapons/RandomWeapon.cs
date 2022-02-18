using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class RandomWeapon : Weapon, IHaveRandomName
    {
        public RandomWeapon(string name, int damage, int durability, int magazine) : base(name, damage, durability, magazine)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }
            else
            {
                Name = name;
            }
        }

        public string GetRandomName()
        {
            Random random = new();

            string[] _names = { "Cannon", "Blaster", "YobaIMHO", "Gigachad", "M4-AK47" };

            string _tempName = _names[random.Next(0, _names.Length)];

            return _tempName;
        }
    }
}
