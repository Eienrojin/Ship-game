using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal abstract class Boat : IHaveInventory
    {
        public Boat(string name, int HP, int maxHP)
        {
            Name = name;
            this.HP = HP;
            MaxHP = maxHP;
            Inventory = new();
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public Weapon UsingWeapon { get; set; } = new RandomWeapon("", 12, 20, 5);
        public List<ILootable> Inventory { get; set; }

        public void GetDamage(int damage)
        {
            HP -= damage;
        }

        public void DeleteItem(List<ILootable> item, int index)
        {
            if (index > item.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Fix Boat\\DeleteItem()");
            }
            {
                item.RemoveAt(index);
            }
        }

        public void ShowInventory()
        {
            int num = 1;

            Console.WriteLine("--------INVENTORY--------");

            Console.WriteLine("--------WEAPON");

            Console.WriteLine(UsingWeapon);

            Console.WriteLine("--------IN");

            if (Inventory.Count == 0 || Inventory is null)
            {
                Console.WriteLine("There's empty!");
            }
            else
            {
                foreach (ILootable item in Inventory)
                {
                    Console.WriteLine($"{num}. {item}");
                    num++;
                }
            }

            Console.WriteLine("-------------------------");
        }

        public ILootable UseItem(List<ILootable> item, int index)
        {
            if(index > item.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Fix Boat\\UseItem()");
            }
            {
                return item[index];
            }
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
