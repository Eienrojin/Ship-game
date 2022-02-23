using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal interface IHaveInventory
    {
        List<ILootable> Inventory { get; set; }

        ILootable UseItem(List<ILootable> items, int index);
        void DeleteItem(List<ILootable> items, int index);
        void ShowInventory();
    }
}
