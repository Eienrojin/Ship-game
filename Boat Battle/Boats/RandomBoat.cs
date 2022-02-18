using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class RandomBoat : Boat, IHaveRandomName
    {
        public RandomBoat(string name, int hP, int maxHP) : base(name, hP, maxHP)
        {
            if(name == "")
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

            string[] _names = { "Linkor", "Plastic boat", "Jumper", "Very big boat", "Geishit" };

            string _tempName = _names[random.Next(0, _names.Length)];

            return _tempName;
        }
    }
}
