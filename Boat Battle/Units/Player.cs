using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal class Player : Unit
    {
        public Player(string name, Boat ownBoat) : base(name, ownBoat)
        {
        }

        public void ShowInventoryMenu()
        {
            while (true)
            {
                int answer;

                OwnBoat.ShowInventory();

                Console.WriteLine("1. Choice weapon" +
                    "\nn. Reload the weapon" +
                    "\nn. Unload the weapon" +
                    "\nn. Repair the ship without repair tool" +
                    "\nn. Repair the ship by the tool" +
                    "\ne. Exit");

                answer = Program.InitAndCheckAnsw();

                switch (answer)
                {
                    default:
                        Console.WriteLine("???");
                        break;
                    case 1:
                        Console.WriteLine("What weapon do you want to use?");

                        answer = Program.InitAndCheckAnsw();

                        if(answer <= OwnBoat.Inventory.Count || answer >= 0)
                        {
                            if (OwnBoat.Inventory[answer] is Weapon)
                            {
                                OwnBoat.Inventory.Add(OwnBoat.UsingWeapon);
                                OwnBoat.UsingWeapon = (Weapon)OwnBoat.Inventory[answer];
                            }
                        }
                        else
                        {
                            Console.WriteLine("The weapon doesn't exist!");
                        }

                        break;
                }
            }
        }
    }
}
