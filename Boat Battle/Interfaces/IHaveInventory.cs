using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Battle
{
    internal interface IHaveInventory
    {
        void UseItem(ILootable item);
        void DeleteItem(ILootable item);
    }
}
