﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.GameObjects.Inventory.ItemSlots;

namespace Game.Interfaces
{
    public interface IItemSlot
    {
        IItem Item { get; set; }

        bool IsEmpty { get; set; }

        int  SlotNumber { get; set; }

        ItemSlotType SlotType { get; set; }
    }
}
